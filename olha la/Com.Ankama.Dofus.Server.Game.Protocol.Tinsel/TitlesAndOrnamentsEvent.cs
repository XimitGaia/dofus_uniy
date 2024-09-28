using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tinsel;

[Token(Token = "0x2000053")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TitlesAndOrnamentsEvent : IMessage<TitlesAndOrnamentsEvent>, IMessage, IEquatable<TitlesAndOrnamentsEvent>, IDeepCloneable<TitlesAndOrnamentsEvent>, IBufferMessage
{
	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TitlesAndOrnamentsEvent> _parser;

	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000114")]
	public const int TitlesFieldNumber = 1;

	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_titles_codec;

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> titles_;

	[Token(Token = "0x4000117")]
	public const int OrnamentsFieldNumber = 2;

	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x10")]
	private static readonly FieldCodec<int> _repeated_ornaments_codec;

	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x20")]
	private readonly RepeatedField<int> ornaments_;

	[Token(Token = "0x17000091")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TitlesAndOrnamentsEvent> Parser
	{
		[Token(Token = "0x600029B")]
		[Address(RVA = "0x944320", Offset = "0x943720", VA = "0x180944320")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000092")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600029C")]
		[Address(RVA = "0x944270", Offset = "0x943670", VA = "0x180944270")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000093")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600029D")]
		[Address(RVA = "0x9445B0", Offset = "0x9439B0", VA = "0x1809445B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000094")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Titles
	{
		[Token(Token = "0x60002A1")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000095")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> Ornaments
	{
		[Token(Token = "0x60002A2")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600029E")]
	[Address(RVA = "0x9441C0", Offset = "0x9435C0", VA = "0x1809441C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TitlesAndOrnamentsEvent()
	{
	}

	[Token(Token = "0x600029F")]
	[Address(RVA = "0x944110", Offset = "0x943510", VA = "0x180944110")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TitlesAndOrnamentsEvent(TitlesAndOrnamentsEvent other)
	{
	}

	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x943BA0", Offset = "0x942FA0", VA = "0x180943BA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TitlesAndOrnamentsEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x943D30", Offset = "0x943130", VA = "0x180943D30", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x943C80", Offset = "0x943080", VA = "0x180943C80", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(TitlesAndOrnamentsEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x943E20", Offset = "0x943220", VA = "0x180943E20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x943F50", Offset = "0x943350", VA = "0x180943F50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x9444D0", Offset = "0x9438D0", VA = "0x1809444D0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x943AC0", Offset = "0x942EC0", VA = "0x180943AC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x943EB0", Offset = "0x9432B0", VA = "0x180943EB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(TitlesAndOrnamentsEvent other)
	{
	}

	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x944370", Offset = "0x943770", VA = "0x180944370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
