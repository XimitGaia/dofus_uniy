using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x2000416")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseGuildRightsEvent : IMessage<HouseGuildRightsEvent>, IMessage, IEquatable<HouseGuildRightsEvent>, IDeepCloneable<HouseGuildRightsEvent>, IBufferMessage
{
	[Token(Token = "0x4000E45")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseGuildRightsEvent> _parser;

	[Token(Token = "0x4000E46")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000E47")]
	public const int HouseIdFieldNumber = 1;

	[Token(Token = "0x4000E48")]
	[FieldOffset(Offset = "0x18")]
	private int houseId_;

	[Token(Token = "0x4000E49")]
	public const int InstanceIdFieldNumber = 2;

	[Token(Token = "0x4000E4A")]
	[FieldOffset(Offset = "0x1C")]
	private int instanceId_;

	[Token(Token = "0x4000E4B")]
	public const int SecondHandFieldNumber = 3;

	[Token(Token = "0x4000E4C")]
	[FieldOffset(Offset = "0x20")]
	private bool secondHand_;

	[Token(Token = "0x4000E4D")]
	public const int GuildInformationFieldNumber = 4;

	[Token(Token = "0x4000E4E")]
	[FieldOffset(Offset = "0x28")]
	private GuildInformation guildInformation_;

	[Token(Token = "0x4000E4F")]
	public const int RightsFieldNumber = 5;

	[Token(Token = "0x4000E50")]
	[FieldOffset(Offset = "0x30")]
	private int rights_;

	[Token(Token = "0x4000E51")]
	public const int IsLockedFieldNumber = 6;

	[Token(Token = "0x4000E52")]
	[FieldOffset(Offset = "0x34")]
	private bool isLocked_;

	[Token(Token = "0x17000944")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HouseGuildRightsEvent> Parser
	{
		[Token(Token = "0x6002B23")]
		[Address(RVA = "0x9C4D40", Offset = "0x9C4140", VA = "0x1809C4D40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000945")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002B24")]
		[Address(RVA = "0x9C4C90", Offset = "0x9C4090", VA = "0x1809C4C90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000946")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002B25")]
		[Address(RVA = "0x9C5020", Offset = "0x9C4420", VA = "0x1809C5020", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000947")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int HouseId
	{
		[Token(Token = "0x6002B29")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002B2A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000948")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int InstanceId
	{
		[Token(Token = "0x6002B2B")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002B2C")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17000949")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool SecondHand
	{
		[Token(Token = "0x6002B2D")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002B2E")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x1700094A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildInformation GuildInformation
	{
		[Token(Token = "0x6002B2F")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002B30")]
		[Address(RVA = "0x96C220", Offset = "0x96B620", VA = "0x18096C220")]
		set
		{
		}
	}

	[Token(Token = "0x1700094B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Rights
	{
		[Token(Token = "0x6002B31")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002B32")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x1700094C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool IsLocked
	{
		[Token(Token = "0x6002B33")]
		[Address(RVA = "0x96E6E0", Offset = "0x96DAE0", VA = "0x18096E6E0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002B34")]
		[Address(RVA = "0x96EC10", Offset = "0x96E010", VA = "0x18096EC10")]
		set
		{
		}
	}

	[Token(Token = "0x6002B26")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseGuildRightsEvent()
	{
	}

	[Token(Token = "0x6002B27")]
	[Address(RVA = "0x9C4C00", Offset = "0x9C4000", VA = "0x1809C4C00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseGuildRightsEvent(HouseGuildRightsEvent other)
	{
	}

	[Token(Token = "0x6002B28")]
	[Address(RVA = "0x9C4630", Offset = "0x9C3A30", VA = "0x1809C4630", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseGuildRightsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002B35")]
	[Address(RVA = "0x9C4780", Offset = "0x9C3B80", VA = "0x1809C4780", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B36")]
	[Address(RVA = "0x9C46F0", Offset = "0x9C3AF0", VA = "0x1809C46F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HouseGuildRightsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002B37")]
	[Address(RVA = "0x9C4860", Offset = "0x9C3C60", VA = "0x1809C4860", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002B38")]
	[Address(RVA = "0x9C4AA0", Offset = "0x9C3EA0", VA = "0x1809C4AA0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002B39")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002B3A")]
	[Address(RVA = "0x9C4F20", Offset = "0x9C4320", VA = "0x1809C4F20", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002B3B")]
	[Address(RVA = "0x9C4510", Offset = "0x9C3910", VA = "0x1809C4510", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002B3C")]
	[Address(RVA = "0x9C49A0", Offset = "0x9C3DA0", VA = "0x1809C49A0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HouseGuildRightsEvent other)
	{
	}

	[Token(Token = "0x6002B3D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002B3E")]
	[Address(RVA = "0x9C4D90", Offset = "0x9C4190", VA = "0x1809C4D90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
