using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x2000390")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ObjectUseOnCharacterRequest : IMessage<ObjectUseOnCharacterRequest>, IMessage, IEquatable<ObjectUseOnCharacterRequest>, IDeepCloneable<ObjectUseOnCharacterRequest>, IBufferMessage
{
	[Token(Token = "0x4000C4B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ObjectUseOnCharacterRequest> _parser;

	[Token(Token = "0x4000C4C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C4D")]
	public const int ObjectUidFieldNumber = 1;

	[Token(Token = "0x4000C4E")]
	[FieldOffset(Offset = "0x18")]
	private int objectUid_;

	[Token(Token = "0x4000C4F")]
	public const int PlayerIdFieldNumber = 2;

	[Token(Token = "0x4000C50")]
	[FieldOffset(Offset = "0x20")]
	private long playerId_;

	[Token(Token = "0x170007F0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ObjectUseOnCharacterRequest> Parser
	{
		[Token(Token = "0x6002504")]
		[Address(RVA = "0x993280", Offset = "0x992680", VA = "0x180993280")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002505")]
		[Address(RVA = "0x9931D0", Offset = "0x9925D0", VA = "0x1809931D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002506")]
		[Address(RVA = "0x9932D0", Offset = "0x9926D0", VA = "0x1809932D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007F3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectUid
	{
		[Token(Token = "0x600250A")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600250B")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170007F4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PlayerId
	{
		[Token(Token = "0x600250C")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600250D")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6002507")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectUseOnCharacterRequest()
	{
	}

	[Token(Token = "0x6002508")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ObjectUseOnCharacterRequest(ObjectUseOnCharacterRequest other)
	{
	}

	[Token(Token = "0x6002509")]
	[Address(RVA = "0x992F40", Offset = "0x992340", VA = "0x180992F40", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectUseOnCharacterRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600250E")]
	[Address(RVA = "0x992FD0", Offset = "0x9923D0", VA = "0x180992FD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600250F")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ObjectUseOnCharacterRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002510")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002511")]
	[Address(RVA = "0x993070", Offset = "0x992470", VA = "0x180993070", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002512")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002513")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002514")]
	[Address(RVA = "0x992E80", Offset = "0x992280", VA = "0x180992E80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002515")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ObjectUseOnCharacterRequest other)
	{
	}

	[Token(Token = "0x6002516")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002517")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
