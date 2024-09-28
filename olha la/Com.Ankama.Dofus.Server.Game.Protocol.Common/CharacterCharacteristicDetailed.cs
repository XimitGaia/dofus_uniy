using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009D9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterCharacteristicDetailed : IMessage<CharacterCharacteristicDetailed>, IMessage, IEquatable<CharacterCharacteristicDetailed>, IDeepCloneable<CharacterCharacteristicDetailed>, IBufferMessage
{
	[Token(Token = "0x40022E4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterCharacteristicDetailed> _parser;

	[Token(Token = "0x40022E5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40022E6")]
	public const int BaseFieldNumber = 1;

	[Token(Token = "0x40022E7")]
	[FieldOffset(Offset = "0x18")]
	private int base_;

	[Token(Token = "0x40022E8")]
	public const int AdditionalFieldNumber = 2;

	[Token(Token = "0x40022E9")]
	[FieldOffset(Offset = "0x1C")]
	private int additional_;

	[Token(Token = "0x40022EA")]
	public const int ObjectsAndMountBonusFieldNumber = 3;

	[Token(Token = "0x40022EB")]
	[FieldOffset(Offset = "0x20")]
	private int objectsAndMountBonus_;

	[Token(Token = "0x40022EC")]
	public const int AlignmentGiftBonusFieldNumber = 4;

	[Token(Token = "0x40022ED")]
	[FieldOffset(Offset = "0x24")]
	private int alignmentGiftBonus_;

	[Token(Token = "0x40022EE")]
	public const int ContextModificationFieldNumber = 5;

	[Token(Token = "0x40022EF")]
	[FieldOffset(Offset = "0x28")]
	private int contextModification_;

	[Token(Token = "0x40022F0")]
	public const int TemporaryFieldNumber = 6;

	[Token(Token = "0x40022F1")]
	[FieldOffset(Offset = "0x2C")]
	private int temporary_;

	[Token(Token = "0x170015F9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterCharacteristicDetailed> Parser
	{
		[Token(Token = "0x600668E")]
		[Address(RVA = "0xBA3380", Offset = "0xBA2780", VA = "0x180BA3380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015FA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600668F")]
		[Address(RVA = "0xBA32D0", Offset = "0xBA26D0", VA = "0x180BA32D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015FB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6006690")]
		[Address(RVA = "0xBA33D0", Offset = "0xBA27D0", VA = "0x180BA33D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170015FC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Base
	{
		[Token(Token = "0x6006694")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006695")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170015FD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Additional
	{
		[Token(Token = "0x6006696")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006697")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170015FE")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectsAndMountBonus
	{
		[Token(Token = "0x6006698")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6006699")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x170015FF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int AlignmentGiftBonus
	{
		[Token(Token = "0x600669A")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600669B")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001600")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ContextModification
	{
		[Token(Token = "0x600669C")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600669D")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x17001601")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Temporary
	{
		[Token(Token = "0x600669E")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600669F")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x6006691")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCharacteristicDetailed()
	{
	}

	[Token(Token = "0x6006692")]
	[Address(RVA = "0xB16C60", Offset = "0xB16060", VA = "0x180B16C60")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCharacteristicDetailed(CharacterCharacteristicDetailed other)
	{
	}

	[Token(Token = "0x6006693")]
	[Address(RVA = "0xBA3020", Offset = "0xBA2420", VA = "0x180BA3020", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCharacteristicDetailed Clone()
	{
		return null;
	}

	[Token(Token = "0x60066A0")]
	[Address(RVA = "0xBA30C0", Offset = "0xBA24C0", VA = "0x180BA30C0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60066A1")]
	[Address(RVA = "0xB16890", Offset = "0xB15C90", VA = "0x180B16890", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterCharacteristicDetailed other)
	{
		return default(bool);
	}

	[Token(Token = "0x60066A2")]
	[Address(RVA = "0xB16990", Offset = "0xB15D90", VA = "0x180B16990", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60066A3")]
	[Address(RVA = "0xBA3170", Offset = "0xBA2570", VA = "0x180BA3170", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60066A4")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60066A5")]
	[Address(RVA = "0xB16F00", Offset = "0xB16300", VA = "0x180B16F00", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60066A6")]
	[Address(RVA = "0xBA2EC0", Offset = "0xBA22C0", VA = "0x180BA2EC0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60066A7")]
	[Address(RVA = "0xB16A80", Offset = "0xB15E80", VA = "0x180B16A80", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterCharacteristicDetailed other)
	{
	}

	[Token(Token = "0x60066A8")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60066A9")]
	[Address(RVA = "0xB16DD0", Offset = "0xB161D0", VA = "0x180B16DD0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
