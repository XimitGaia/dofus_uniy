using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CE1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceFightStartedEvent : IMessage<AllianceFightStartedEvent>, IMessage, IEquatable<AllianceFightStartedEvent>, IDeepCloneable<AllianceFightStartedEvent>, IBufferMessage
{
	[Token(Token = "0x4002F65")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceFightStartedEvent> _parser;

	[Token(Token = "0x4002F66")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F67")]
	public const int FightInformationFieldNumber = 1;

	[Token(Token = "0x4002F68")]
	[FieldOffset(Offset = "0x18")]
	private SocialFightInformation fightInformation_;

	[Token(Token = "0x4002F69")]
	public const int PhaseFieldNumber = 2;

	[Token(Token = "0x4002F6A")]
	[FieldOffset(Offset = "0x20")]
	private FightPhaseInfo phase_;

	[Token(Token = "0x17001DAA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceFightStartedEvent> Parser
	{
		[Token(Token = "0x60087B9")]
		[Address(RVA = "0xCAE110", Offset = "0xCAD510", VA = "0x180CAE110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DAB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60087BA")]
		[Address(RVA = "0xCAE060", Offset = "0xCAD460", VA = "0x180CAE060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DAC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60087BB")]
		[Address(RVA = "0xCAE2B0", Offset = "0xCAD6B0", VA = "0x180CAE2B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DAD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialFightInformation FightInformation
	{
		[Token(Token = "0x60087BF")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087C0")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001DAE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FightPhaseInfo Phase
	{
		[Token(Token = "0x60087C1")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087C2")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60087BC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightStartedEvent()
	{
	}

	[Token(Token = "0x60087BD")]
	[Address(RVA = "0xCAD040", Offset = "0xCAC440", VA = "0x180CAD040")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightStartedEvent(AllianceFightStartedEvent other)
	{
	}

	[Token(Token = "0x60087BE")]
	[Address(RVA = "0xCADC40", Offset = "0xCAD040", VA = "0x180CADC40", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightStartedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60087C3")]
	[Address(RVA = "0xCADD10", Offset = "0xCAD110", VA = "0x180CADD10", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60087C4")]
	[Address(RVA = "0x96C3C0", Offset = "0x96B7C0", VA = "0x18096C3C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceFightStartedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60087C5")]
	[Address(RVA = "0x96C500", Offset = "0x96B900", VA = "0x18096C500", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60087C6")]
	[Address(RVA = "0xCADF00", Offset = "0xCAD300", VA = "0x180CADF00", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60087C7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60087C8")]
	[Address(RVA = "0x96CB10", Offset = "0x96BF10", VA = "0x18096CB10", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60087C9")]
	[Address(RVA = "0xCADB80", Offset = "0xCACF80", VA = "0x180CADB80", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60087CA")]
	[Address(RVA = "0xCADDD0", Offset = "0xCAD1D0", VA = "0x180CADDD0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceFightStartedEvent other)
	{
	}

	[Token(Token = "0x60087CB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60087CC")]
	[Address(RVA = "0xCAE160", Offset = "0xCAD560", VA = "0x180CAE160", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
