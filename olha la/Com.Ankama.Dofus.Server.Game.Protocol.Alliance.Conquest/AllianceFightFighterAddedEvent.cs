using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CE7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceFightFighterAddedEvent : IMessage<AllianceFightFighterAddedEvent>, IMessage, IEquatable<AllianceFightFighterAddedEvent>, IDeepCloneable<AllianceFightFighterAddedEvent>, IBufferMessage
{
	[Token(Token = "0x4002F78")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceFightFighterAddedEvent> _parser;

	[Token(Token = "0x4002F79")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F7A")]
	public const int FightInformationFieldNumber = 1;

	[Token(Token = "0x4002F7B")]
	[FieldOffset(Offset = "0x18")]
	private SocialFightInformation fightInformation_;

	[Token(Token = "0x4002F7C")]
	public const int FighterFieldNumber = 2;

	[Token(Token = "0x4002F7D")]
	[FieldOffset(Offset = "0x20")]
	private Com.Ankama.Dofus.Server.Game.Protocol.Common.Character fighter_;

	[Token(Token = "0x4002F7E")]
	public const int TeamFieldNumber = 3;

	[Token(Token = "0x4002F7F")]
	[FieldOffset(Offset = "0x28")]
	private Team team_;

	[Token(Token = "0x17001DB8")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceFightFighterAddedEvent> Parser
	{
		[Token(Token = "0x60087FF")]
		[Address(RVA = "0xCAA270", Offset = "0xCA9670", VA = "0x180CAA270")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DB9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008800")]
		[Address(RVA = "0xCAA1C0", Offset = "0xCA95C0", VA = "0x180CAA1C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DBA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008801")]
		[Address(RVA = "0xCAA4D0", Offset = "0xCA98D0", VA = "0x180CAA4D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DBB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialFightInformation FightInformation
	{
		[Token(Token = "0x6008805")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008806")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001DBC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Com.Ankama.Dofus.Server.Game.Protocol.Common.Character Fighter
	{
		[Token(Token = "0x6008807")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008808")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x17001DBD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Team Team
	{
		[Token(Token = "0x6008809")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(Team);
		}
		[Token(Token = "0x600880A")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x6008802")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightFighterAddedEvent()
	{
	}

	[Token(Token = "0x6008803")]
	[Address(RVA = "0xCAA110", Offset = "0xCA9510", VA = "0x180CAA110")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightFighterAddedEvent(AllianceFightFighterAddedEvent other)
	{
	}

	[Token(Token = "0x6008804")]
	[Address(RVA = "0xCA9BA0", Offset = "0xCA8FA0", VA = "0x180CA9BA0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceFightFighterAddedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600880B")]
	[Address(RVA = "0xCA9C80", Offset = "0xCA9080", VA = "0x180CA9C80", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600880C")]
	[Address(RVA = "0xCA9D50", Offset = "0xCA9150", VA = "0x180CA9D50", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceFightFighterAddedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600880D")]
	[Address(RVA = "0xCA9DD0", Offset = "0xCA91D0", VA = "0x180CA9DD0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600880E")]
	[Address(RVA = "0xCA9FB0", Offset = "0xCA93B0", VA = "0x180CA9FB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600880F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008810")]
	[Address(RVA = "0xCAA430", Offset = "0xCA9830", VA = "0x180CAA430", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008811")]
	[Address(RVA = "0xCA9AB0", Offset = "0xCA8EB0", VA = "0x180CA9AB0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008812")]
	[Address(RVA = "0xCA9E80", Offset = "0xCA9280", VA = "0x180CA9E80", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceFightFighterAddedEvent other)
	{
	}

	[Token(Token = "0x6008813")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008814")]
	[Address(RVA = "0xCAA2C0", Offset = "0xCA96C0", VA = "0x180CAA2C0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
