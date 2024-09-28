using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C62")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceApplicationListRequest : IMessage<AllianceApplicationListRequest>, IMessage, IEquatable<AllianceApplicationListRequest>, IDeepCloneable<AllianceApplicationListRequest>, IBufferMessage
{
	[Token(Token = "0x4002DCE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceApplicationListRequest> _parser;

	[Token(Token = "0x4002DCF")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002DD0")]
	public const int OffsetFieldNumber = 1;

	[Token(Token = "0x4002DD1")]
	[FieldOffset(Offset = "0x18")]
	private long offset_;

	[Token(Token = "0x4002DD2")]
	public const int CountFieldNumber = 2;

	[Token(Token = "0x4002DD3")]
	[FieldOffset(Offset = "0x20")]
	private long count_;

	[Token(Token = "0x17001C8E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceApplicationListRequest> Parser
	{
		[Token(Token = "0x6008245")]
		[Address(RVA = "0xC71100", Offset = "0xC70500", VA = "0x180C71100")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C8F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008246")]
		[Address(RVA = "0xC71050", Offset = "0xC70450", VA = "0x180C71050")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C90")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008247")]
		[Address(RVA = "0xC71150", Offset = "0xC70550", VA = "0x180C71150", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C91")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long Offset
	{
		[Token(Token = "0x600824B")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600824C")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x17001C92")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Count
	{
		[Token(Token = "0x600824D")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600824E")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6008248")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationListRequest()
	{
	}

	[Token(Token = "0x6008249")]
	[Address(RVA = "0x951C30", Offset = "0x951030", VA = "0x180951C30")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceApplicationListRequest(AllianceApplicationListRequest other)
	{
	}

	[Token(Token = "0x600824A")]
	[Address(RVA = "0xC70DC0", Offset = "0xC701C0", VA = "0x180C70DC0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceApplicationListRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600824F")]
	[Address(RVA = "0xC70E50", Offset = "0xC70250", VA = "0x180C70E50", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008250")]
	[Address(RVA = "0x951900", Offset = "0x950D00", VA = "0x180951900", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceApplicationListRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008251")]
	[Address(RVA = "0x9519E0", Offset = "0x950DE0", VA = "0x1809519E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008252")]
	[Address(RVA = "0xC70EF0", Offset = "0xC702F0", VA = "0x180C70EF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008253")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008254")]
	[Address(RVA = "0x951E40", Offset = "0x951240", VA = "0x180951E40", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008255")]
	[Address(RVA = "0xC70D00", Offset = "0xC70100", VA = "0x180C70D00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008256")]
	[Address(RVA = "0x951A70", Offset = "0x950E70", VA = "0x180951A70", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceApplicationListRequest other)
	{
	}

	[Token(Token = "0x6008257")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008258")]
	[Address(RVA = "0x951D90", Offset = "0x951190", VA = "0x180951D90", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
