using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.House;

[Token(Token = "0x2000405")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HouseGuildShareRequest : IMessage<HouseGuildShareRequest>, IMessage, IEquatable<HouseGuildShareRequest>, IDeepCloneable<HouseGuildShareRequest>, IBufferMessage
{
	[Token(Token = "0x4000DDB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HouseGuildShareRequest> _parser;

	[Token(Token = "0x4000DDC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000DDD")]
	public const int HouseIdFieldNumber = 1;

	[Token(Token = "0x4000DDE")]
	[FieldOffset(Offset = "0x18")]
	private int houseId_;

	[Token(Token = "0x4000DDF")]
	public const int InstanceIdFieldNumber = 2;

	[Token(Token = "0x4000DE0")]
	[FieldOffset(Offset = "0x1C")]
	private int instanceId_;

	[Token(Token = "0x4000DE1")]
	public const int ShareFieldNumber = 3;

	[Token(Token = "0x4000DE2")]
	[FieldOffset(Offset = "0x20")]
	private bool share_;

	[Token(Token = "0x4000DE3")]
	public const int RightsFieldNumber = 4;

	[Token(Token = "0x4000DE4")]
	[FieldOffset(Offset = "0x24")]
	private int rights_;

	[Token(Token = "0x17000905")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<HouseGuildShareRequest> Parser
	{
		[Token(Token = "0x6002A39")]
		[Address(RVA = "0x99C6E0", Offset = "0x99BAE0", VA = "0x18099C6E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000906")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002A3A")]
		[Address(RVA = "0x99C630", Offset = "0x99BA30", VA = "0x18099C630")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000907")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002A3B")]
		[Address(RVA = "0x99C730", Offset = "0x99BB30", VA = "0x18099C730", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000908")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int HouseId
	{
		[Token(Token = "0x6002A3F")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002A40")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000909")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int InstanceId
	{
		[Token(Token = "0x6002A41")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002A42")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700090A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Share
	{
		[Token(Token = "0x6002A43")]
		[Address(RVA = "0x7F9A60", Offset = "0x7F8E60", VA = "0x1807F9A60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002A44")]
		[Address(RVA = "0x7F9A70", Offset = "0x7F8E70", VA = "0x1807F9A70")]
		set
		{
		}
	}

	[Token(Token = "0x1700090B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Rights
	{
		[Token(Token = "0x6002A45")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002A46")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x6002A3C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseGuildShareRequest()
	{
	}

	[Token(Token = "0x6002A3D")]
	[Address(RVA = "0x989A80", Offset = "0x988E80", VA = "0x180989A80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseGuildShareRequest(HouseGuildShareRequest other)
	{
	}

	[Token(Token = "0x6002A3E")]
	[Address(RVA = "0x99C2B0", Offset = "0x99B6B0", VA = "0x18099C2B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HouseGuildShareRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002A47")]
	[Address(RVA = "0x99C340", Offset = "0x99B740", VA = "0x18099C340", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A48")]
	[Address(RVA = "0x9896D0", Offset = "0x988AD0", VA = "0x1809896D0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HouseGuildShareRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002A49")]
	[Address(RVA = "0x99C3E0", Offset = "0x99B7E0", VA = "0x18099C3E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002A4A")]
	[Address(RVA = "0x99C4D0", Offset = "0x99B8D0", VA = "0x18099C4D0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002A4B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002A4C")]
	[Address(RVA = "0x989CE0", Offset = "0x9890E0", VA = "0x180989CE0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002A4D")]
	[Address(RVA = "0x99C1C0", Offset = "0x99B5C0", VA = "0x18099C1C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002A4E")]
	[Address(RVA = "0x9898B0", Offset = "0x988CB0", VA = "0x1809898B0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(HouseGuildShareRequest other)
	{
	}

	[Token(Token = "0x6002A4F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002A50")]
	[Address(RVA = "0x989BE0", Offset = "0x988FE0", VA = "0x180989BE0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
