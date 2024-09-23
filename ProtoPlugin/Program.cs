using Google.Protobuf.Reflection;
using ProtoBuf;
using Rpc;
using System.Text;

namespace ProtoPlugin
{
    internal class Program
    {
        private static string FileDescriptorSetPath;
        private static string ProtoCodeTemplate = @"using Foundation;
using Rpc;
using System;
using System.Collections.Generic;

public static class MessageMapCenter
{{
    private static readonly Dictionary<Type, ushort> typeMessageId = new Dictionary<Type, ushort>()
        {{
{0}

        }};
    private static readonly Dictionary<ushort, Type> ntfMessage = new Dictionary<ushort, Type>()
    {{
{1}
    }};


    public static ushort GetMessageId(Type type)
    {{
        if (typeMessageId.TryGetValue(type, out ushort messageId))
        {{
            return messageId;
        }}
        Log.LogError($""GetMessageId is not exist ,type:{{type.Name}}"");
        return 0;
    }}

    public static Type GetNtfById(ushort messageId)
    {{
        if (ntfMessage.TryGetValue(messageId, out Type type))
        {{
            return type;
        }}
        Log.LogError($""GetNtfById is not exist ,messageId:{{messageId}}"");
        return null;
    }}
}}
";
        private static string ProtoCodeGenPath;

        private static string ErrorMapCodeTemplate = @"
using System.Collections.Generic;

public static class ProtoErrorMap
{{
    private static Dictionary<int, string> _errorMap = new Dictionary<int, string>()
    {{
{0}
    }};

    public static string GetError(int errorCode)
    {{
        if (_errorMap.TryGetValue(errorCode, out string error))
        {{
            return error;
        }}
        return ""Unknown error"";
    }}
}}";
        private static string ErrorMapCodeGenPath;
        static void Main(string[] args)
        {
            var argLength = args.Length;
            if (argLength < 3)
            {
                Console.WriteLine("Arg length is less than 3");
                return;
            }

            foreach (var item in args)
            {
                var split = item.Split("=");
                if (split.Length != 2)
                {
                    Console.WriteLine("Arg format is wrong");
                    return;
                }

                switch (split[0])
                {
                    case "-File":
                        FileDescriptorSetPath = split[1];
                        break;
                    case "-ProtoIdMap":
                        ProtoCodeGenPath = split[1];
                        break;
                    case "-ErrorIdMap":
                        ErrorMapCodeGenPath = split[1];
                        break;
                    default:
                        break;
                }
            }
            var protoPath = FileDescriptorSetPath;
            FileDescriptorSet set;
            using (var file = File.OpenRead(protoPath))
            {
                set = Serializer.Deserialize<FileDescriptorSet>(file);
                foreach (var item in set.Files)
                {
                    if (item.Name == "api.proto")
                    {
                        ProcessApi(item);
                    }
                    else if (item.Name == "error.proto")
                    {
                        ProcessError(item);
                    }
                }
            }
        }

        private static void ProcessApi(FileDescriptorProto fileProto)
        {
            var protoIdEnum = fileProto.EnumTypes.FirstOrDefault((e) => e.Name == "ProtoId");
            if (protoIdEnum != null)
            {
                StringBuilder typeToId = new StringBuilder();
                StringBuilder ntfIdToType = new StringBuilder();

                foreach (var item in protoIdEnum.Values)
                {
                    var req = item.Options.GetReq();
                    var ack = item.Options.GetAck();
                    var value = item.Number;
                    if (req == null && ack == null)
                    {
                        continue;
                    }
                    if (req == null)
                    {
                        ntfIdToType.AppendLine($"{{{value},typeof({ack})}},");
                    }
                    else
                    {
                        typeToId.AppendLine($"{{typeof({req}),{value}}},");
                        typeToId.AppendLine($"{{typeof({ack}),{value}}},");
                    }
                }
                var code = string.Format(ProtoCodeTemplate, typeToId.ToString(), ntfIdToType.ToString());
                File.WriteAllText(ProtoCodeGenPath, code);
            }
            else
            {
                Console.WriteLine("ProtoId Enum not found in api.proto");
            }
        }

        private static void ProcessError(FileDescriptorProto fileProto)
        {
            var protoIdEnum = fileProto.EnumTypes.FirstOrDefault((e) => e.Name == "State");
            if (protoIdEnum != null)
            {
                StringBuilder errorMap = new StringBuilder();

                foreach (var item in protoIdEnum.Values)
                {
                    var errorCode = item.Options.GetDesc();
                    var value = item.Number;
                    if (errorCode == null)
                    {
                        continue;
                    }
                    errorMap.AppendLine($"{{{value},\"{errorCode}\"}},");
                }
                var code = string.Format(ErrorMapCodeTemplate, errorMap.ToString());
                File.WriteAllText(ErrorMapCodeGenPath, code);
            }
            else
            {
                Console.WriteLine("ErroProto Enum not found in error.proto");
            }
        }
    }


}
