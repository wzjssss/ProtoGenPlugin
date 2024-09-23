// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: rpc.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Rpc
{

    [global::ProtoBuf.ProtoContract()]
    public partial class StreamMsg : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"front")]
        public Front Front
        {
            get => __pbn__Msg.Is(1) ? ((Front)__pbn__Msg.Object) : default;
            set => __pbn__Msg = new global::ProtoBuf.DiscriminatedUnionObject(1, value);
        }
        public bool ShouldSerializeFront() => __pbn__Msg.Is(1);
        public void ResetFront() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__Msg, 1);

        private global::ProtoBuf.DiscriminatedUnionObject __pbn__Msg;

        [global::ProtoBuf.ProtoMember(2, Name = @"node")]
        public Node Node
        {
            get => __pbn__Msg.Is(2) ? ((Node)__pbn__Msg.Object) : default;
            set => __pbn__Msg = new global::ProtoBuf.DiscriminatedUnionObject(2, value);
        }
        public bool ShouldSerializeNode() => __pbn__Msg.Is(2);
        public void ResetNode() => global::ProtoBuf.DiscriminatedUnionObject.Reset(ref __pbn__Msg, 2);

        [global::ProtoBuf.ProtoMember(101)]
        public long userId { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Front : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"cfg")]
        public int Cfg { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"mode")]
        public int Mode { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public uint protoId { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public uint SynID { get; set; }

        [global::ProtoBuf.ProtoMember(5)]
        public uint seqId { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"data")]
        public byte[] Data { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class Node : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(2, Name = @"mode")]
        public int Mode { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public Call callId { get; set; }

        [global::ProtoBuf.ProtoMember(4)]
        public uint seqId { get; set; }

        [global::ProtoBuf.ProtoMember(6, Name = @"data")]
        public byte[] Data { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public enum NodeMode
    {
        Push = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"REQACK")]
        Reqack = 1,
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
