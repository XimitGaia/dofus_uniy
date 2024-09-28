using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel;

[Token(Token = "0x2000051")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TitlesAndOrnamentsRequest : IMessage<TitlesAndOrnamentsRequest>, IMessage, IEquatable<TitlesAndOrnamentsRequest>, IDeepCloneable<TitlesAndOrnamentsRequest>, IBufferMessage
{
	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TitlesAndOrnamentsRequest> _parser;

	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700008E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<TitlesAndOrnamentsRequest> Parser
	{
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x9449A0", Offset = "0x943DA0", VA = "0x1809449A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700008F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000288")]
		[Address(RVA = "0x9448F0", Offset = "0x943CF0", VA = "0x1809448F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000090")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000289")]
		[Address(RVA = "0x9449F0", Offset = "0x943DF0", VA = "0x1809449F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600028A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TitlesAndOrnamentsRequest()
	{
	}

	[Token(Token = "0x600028B")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TitlesAndOrnamentsRequest(TitlesAndOrnamentsRequest other)
	{
	}

	[Token(Token = "0x600028C")]
	[Address(RVA = "0x944690", Offset = "0x943A90", VA = "0x180944690", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TitlesAndOrnamentsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600028D")]
	[Address(RVA = "0x944710", Offset = "0x943B10", VA = "0x180944710", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600028E")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TitlesAndOrnamentsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600028F")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000290")]
	[Address(RVA = "0x944790", Offset = "0x943B90", VA = "0x180944790", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000291")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000292")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000293")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000294")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TitlesAndOrnamentsRequest other)
	{
	}

	[Token(Token = "0x6000295")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000296")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
