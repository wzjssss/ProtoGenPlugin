// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: error.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
namespace Rpc
{

    [global::ProtoBuf.ProtoContract()]
    public partial class ErrCode : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"state")]
        public State State { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string errMsg { get; set; } = "";

    }

    [global::ProtoBuf.ProtoContract()]
    public enum State
    {
        [global::ProtoBuf.ProtoEnum(Name = @"SUCCESS")]
        Success = 0,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_LOGIN_ROLE_001")]
        ErrorLoginRole001 = 1,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_LOGIN_ROLE_002")]
        ErrorLoginRole002 = 2,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_001")]
        ErrorSystem001 = 201,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_002")]
        ErrorSystem002 = 202,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_003")]
        ErrorSystem003 = 203,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_004")]
        ErrorSystem004 = 204,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_005")]
        ErrorSystem005 = 205,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_006")]
        ErrorSystem006 = 206,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_007")]
        ErrorSystem007 = 207,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_008")]
        ErrorSystem008 = 208,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_016")]
        ErrorSystem016 = 216,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_017")]
        ErrorSystem017 = 217,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_020")]
        ErrorSystem020 = 220,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_026")]
        ErrorSystem026 = 226,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_027")]
        ErrorSystem027 = 227,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_028")]
        ErrorSystem028 = 228,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SYSTEM_029")]
        ErrorSystem029 = 229,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_COMMON_001")]
        ErrorCommon001 = 301,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_COMMON_002")]
        ErrorCommon002 = 302,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_COMMON_003")]
        ErrorCommon003 = 303,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SHOP_001")]
        ErrorShop001 = 401,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SALESMAN_001")]
        ErrorSalesman001 = 501,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SALESMAN_002")]
        ErrorSalesman002 = 502,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SALESMAN_003")]
        ErrorSalesman003 = 503,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SALESMAN_004")]
        ErrorSalesman004 = 504,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_SALESMAN_005")]
        ErrorSalesman005 = 505,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_MAP_001")]
        ErrorMap001 = 601,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_MAP_002")]
        ErrorMap002 = 602,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_MAP_003")]
        ErrorMap003 = 603,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_MAP_004")]
        ErrorMap004 = 604,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_BAG_001")]
        ErrorBag001 = 701,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_BAG_002")]
        ErrorBag002 = 702,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_BAG_003")]
        ErrorBag003 = 703,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_BAG_004")]
        ErrorBag004 = 704,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_PET_001")]
        ErrorPet001 = 801,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_PET_002")]
        ErrorPet002 = 802,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_PET_003")]
        ErrorPet003 = 803,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_PET_004")]
        ErrorPet004 = 804,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_PET_005")]
        ErrorPet005 = 805,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_BUILD_001")]
        ErrorBuild001 = 901,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_BUILD_002")]
        ErrorBuild002 = 902,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_INCUBATION_002")]
        ErrorIncubation002 = 1001,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_TASK_001")]
        ErrorTask001 = 1101,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_TASK_002")]
        ErrorTask002 = 1102,
        [global::ProtoBuf.ProtoEnum(Name = @"ERROR_TASK_003")]
        ErrorTask003 = 1103,
    }

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion
