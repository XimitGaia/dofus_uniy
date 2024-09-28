using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CE5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceFightPhaseUpdateEvent : IMessage<AllianceFightPhaseUpdateEvent>, IMessage, IEquatable<AllianceFightPhaseUpdateEvent>, IDeepCloneable<AllianceFightPhaseUpdateEvent>, IBufferMessage
{
	[Token(Token = "0x4002F71")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceFightPhaseUpdateEvent> _parser;

	[Token(Token = "0x4002F72")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F73")]
	public const int FightInformationFieldNumber = 1;

	[Token(Token = "0x4002F74")]
	[FieldOffset(Offset = "0x18")]
	private SocialFightInformation fightInformation_;

	[Token(Token = "0x4002F75")]
	public const int PhaseFieldNumber = 2;

	[Token(Token = "0x4002F76")]
	[FieldOffset(Offset = "0x20")]
	private FightPhaseInfo phase_;

	[Token(Token = "0x17001DB3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceFightPhaseUpdateEvent> Parser
	{
		[Token(Token = "0x60087E7")]
		[Address(RVA = "0xCAD190", Offset = "0xCAC590", VA = "0x180CAD190")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DB4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60087E8")]
		[Address(RVA = "0xCAD0E0", Offset = "0xCAC4E0", VA = "0x180CAD0E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DB5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60087E9")]
		[Address(RVA = "0xCAD330", Offset = "0xCAC730", VA = "0x180CAD330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DB6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialFightInformation FightInformation
	{
		[Token(Token = "0x60087ED")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087EE")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001DB7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FightPhaseInfo Phase
	{
		[Token(Token = "0x60087EF")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60087F0")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60087EA")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightPhaseUpdateEvent()
	{
	}

	[Token(Token = "0x60087EB")]
	[Address(RVA = "0xCAD040", Offset = "0xCAC440", VA = "0x180CAD040")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceFightPhaseUpdateEvent(AllianceFightPhaseUpdateEvent other)
	{
	}

	[Token(Token = "0x60087EC")]
	[Address(RVA = "0xCACC20", Offset = "0xCAC020", VA = "0x180CACC20", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightPhaseUpdateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60087F1")]
	[Address(RVA = "0xCACCF0", Offset = "0xCAC0F0", VA = "0x180CACCF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60087F2")]
	[Address(RVA = "0x96C3C0", Offset = "0x96B7C0", VA = "0x18096C3C0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceFightPhaseUpdateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60087F3")]
	[Address(RVA = "0x96C500", Offset = "0x96B900", VA = "0x18096C500", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60087F4")]
	[Address(RVA = "0xCACEE0", Offset = "0xCAC2E0", VA = "0x180CACEE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60087F5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60087F6")]
	[Address(RVA = "0x96CB10", Offset = "0x96BF10", VA = "0x18096CB10", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60087F7")]
	[Address(RVA = "0xCACB60", Offset = "0xCABF60", VA = "0x180CACB60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60087F8")]
	[Address(RVA = "0xCACDB0", Offset = "0xCAC1B0", VA = "0x180CACDB0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceFightPhaseUpdateEvent other)
	{
	}

	[Token(Token = "0x60087F9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60087FA")]
	[Address(RVA = "0xCAD1E0", Offset = "0xCAC5E0", VA = "0x180CAD1E0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
