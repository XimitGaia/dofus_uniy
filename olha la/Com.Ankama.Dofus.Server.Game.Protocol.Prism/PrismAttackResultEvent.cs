using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Prism;

[Token(Token = "0x20001C3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PrismAttackResultEvent : IMessage<PrismAttackResultEvent>, IMessage, IEquatable<PrismAttackResultEvent>, IDeepCloneable<PrismAttackResultEvent>, IBufferMessage
{
	[Token(Token = "0x20001C4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x20001C5")]
		public enum PrismAttackResult
		{
			[Token(Token = "0x40005E9")]
			[OriginalName("DEFENDERS_WIN")]
			DefendersWin,
			[Token(Token = "0x40005EA")]
			[OriginalName("ATTACKERS_WIN")]
			AttackersWin
		}
	}

	[Token(Token = "0x40005E2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PrismAttackResultEvent> _parser;

	[Token(Token = "0x40005E3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40005E4")]
	public const int PrismLocalizedInformationFieldNumber = 1;

	[Token(Token = "0x40005E5")]
	[FieldOffset(Offset = "0x18")]
	private PrismLocalizedInformation prismLocalizedInformation_;

	[Token(Token = "0x40005E6")]
	public const int PrismAttackResultFieldNumber = 2;

	[Token(Token = "0x40005E7")]
	[FieldOffset(Offset = "0x20")]
	private Types.PrismAttackResult prismAttackResult_;

	[Token(Token = "0x170003C9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PrismAttackResultEvent> Parser
	{
		[Token(Token = "0x60011DF")]
		[Address(RVA = "0xCCEE10", Offset = "0xCCE210", VA = "0x180CCEE10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003CA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60011E0")]
		[Address(RVA = "0xCCED60", Offset = "0xCCE160", VA = "0x180CCED60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003CB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60011E1")]
		[Address(RVA = "0xCCEF80", Offset = "0xCCE380", VA = "0x180CCEF80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003CC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismLocalizedInformation PrismLocalizedInformation
	{
		[Token(Token = "0x60011E5")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60011E6")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x170003CD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.PrismAttackResult PrismAttackResult
	{
		[Token(Token = "0x60011E7")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(Types.PrismAttackResult);
		}
		[Token(Token = "0x60011E8")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x60011E2")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismAttackResultEvent()
	{
	}

	[Token(Token = "0x60011E3")]
	[Address(RVA = "0xCCECE0", Offset = "0xCCE0E0", VA = "0x180CCECE0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismAttackResultEvent(PrismAttackResultEvent other)
	{
	}

	[Token(Token = "0x60011E4")]
	[Address(RVA = "0xCCE950", Offset = "0xCCDD50", VA = "0x180CCE950", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PrismAttackResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60011E9")]
	[Address(RVA = "0xCCEA00", Offset = "0xCCDE00", VA = "0x180CCEA00", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60011EA")]
	[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PrismAttackResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60011EB")]
	[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60011EC")]
	[Address(RVA = "0xCCEB80", Offset = "0xCCDF80", VA = "0x180CCEB80", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60011ED")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60011EE")]
	[Address(RVA = "0x98B200", Offset = "0x98A600", VA = "0x18098B200", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60011EF")]
	[Address(RVA = "0xCCE890", Offset = "0xCCDC90", VA = "0x180CCE890", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60011F0")]
	[Address(RVA = "0xCCEAB0", Offset = "0xCCDEB0", VA = "0x180CCEAB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PrismAttackResultEvent other)
	{
	}

	[Token(Token = "0x60011F1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60011F2")]
	[Address(RVA = "0xCCEE60", Offset = "0xCCE260", VA = "0x180CCEE60", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
