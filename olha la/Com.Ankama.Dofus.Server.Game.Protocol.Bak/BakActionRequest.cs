using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Bak;

[Token(Token = "0x2000B68")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BakActionRequest : IMessage<BakActionRequest>, IMessage, IEquatable<BakActionRequest>, IDeepCloneable<BakActionRequest>, IBufferMessage
{
	[Token(Token = "0x4002A99")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BakActionRequest> _parser;

	[Token(Token = "0x4002A9A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002A9B")]
	public const int KamasFieldNumber = 1;

	[Token(Token = "0x4002A9C")]
	[FieldOffset(Offset = "0x18")]
	private long kamas_;

	[Token(Token = "0x4002A9D")]
	public const int OgrinesFieldNumber = 2;

	[Token(Token = "0x4002A9E")]
	[FieldOffset(Offset = "0x20")]
	private long ogrines_;

	[Token(Token = "0x4002A9F")]
	public const int RateFieldNumber = 3;

	[Token(Token = "0x4002AA0")]
	[FieldOffset(Offset = "0x28")]
	private int rate_;

	[Token(Token = "0x4002AA1")]
	public const int BidActionFieldNumber = 4;

	[Token(Token = "0x4002AA2")]
	[FieldOffset(Offset = "0x2C")]
	private BidAction bidAction_;

	[Token(Token = "0x17001A73")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BakActionRequest> Parser
	{
		[Token(Token = "0x6007819")]
		[Address(RVA = "0xC1A790", Offset = "0xC19B90", VA = "0x180C1A790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A74")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600781A")]
		[Address(RVA = "0xC1A6E0", Offset = "0xC19AE0", VA = "0x180C1A6E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A75")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600781B")]
		[Address(RVA = "0xC1A9A0", Offset = "0xC19DA0", VA = "0x180C1A9A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001A76")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Kamas
	{
		[Token(Token = "0x600781F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6007820")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001A77")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Ogrines
	{
		[Token(Token = "0x6007821")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6007822")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A78")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Rate
	{
		[Token(Token = "0x6007823")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007824")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17001A79")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BidAction BidAction
	{
		[Token(Token = "0x6007825")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(BidAction);
		}
		[Token(Token = "0x6007826")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x600781C")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakActionRequest()
	{
	}

	[Token(Token = "0x600781D")]
	[Address(RVA = "0xC1A670", Offset = "0xC19A70", VA = "0x180C1A670")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakActionRequest(BakActionRequest other)
	{
	}

	[Token(Token = "0x600781E")]
	[Address(RVA = "0xC1A220", Offset = "0xC19620", VA = "0x180C1A220", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BakActionRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6007827")]
	[Address(RVA = "0xC1A310", Offset = "0xC19710", VA = "0x180C1A310", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007828")]
	[Address(RVA = "0xC1A2C0", Offset = "0xC196C0", VA = "0x180C1A2C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(BakActionRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007829")]
	[Address(RVA = "0xC1A3C0", Offset = "0xC197C0", VA = "0x180C1A3C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600782A")]
	[Address(RVA = "0xC1A510", Offset = "0xC19910", VA = "0x180C1A510", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600782B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600782C")]
	[Address(RVA = "0xC1A8E0", Offset = "0xC19CE0", VA = "0x180C1A8E0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600782D")]
	[Address(RVA = "0xC1A110", Offset = "0xC19510", VA = "0x180C1A110", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600782E")]
	[Address(RVA = "0xC1A490", Offset = "0xC19890", VA = "0x180C1A490", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(BakActionRequest other)
	{
	}

	[Token(Token = "0x600782F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007830")]
	[Address(RVA = "0xC1A7E0", Offset = "0xC19BE0", VA = "0x180C1A7E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
