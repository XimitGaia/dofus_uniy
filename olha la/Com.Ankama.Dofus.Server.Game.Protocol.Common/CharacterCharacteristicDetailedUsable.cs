using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x20009DB")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterCharacteristicDetailedUsable : IMessage<CharacterCharacteristicDetailedUsable>, IMessage, IEquatable<CharacterCharacteristicDetailedUsable>, IDeepCloneable<CharacterCharacteristicDetailedUsable>, IBufferMessage
{
	[Token(Token = "0x40022F3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterCharacteristicDetailedUsable> _parser;

	[Token(Token = "0x40022F4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40022F5")]
	public const int BaseFieldNumber = 1;

	[Token(Token = "0x40022F6")]
	[FieldOffset(Offset = "0x18")]
	private int base_;

	[Token(Token = "0x40022F7")]
	public const int AdditionalFieldNumber = 2;

	[Token(Token = "0x40022F8")]
	[FieldOffset(Offset = "0x1C")]
	private int additional_;

	[Token(Token = "0x40022F9")]
	public const int ObjectsAndMountBonusFieldNumber = 3;

	[Token(Token = "0x40022FA")]
	[FieldOffset(Offset = "0x20")]
	private int objectsAndMountBonus_;

	[Token(Token = "0x40022FB")]
	public const int AlignmentGiftBonusFieldNumber = 4;

	[Token(Token = "0x40022FC")]
	[FieldOffset(Offset = "0x24")]
	private int alignmentGiftBonus_;

	[Token(Token = "0x40022FD")]
	public const int ContextModificationFieldNumber = 5;

	[Token(Token = "0x40022FE")]
	[FieldOffset(Offset = "0x28")]
	private int contextModification_;

	[Token(Token = "0x40022FF")]
	public const int UsedFieldNumber = 6;

	[Token(Token = "0x4002300")]
	[FieldOffset(Offset = "0x2C")]
	private int used_;

	[Token(Token = "0x4002301")]
	public const int TemporaryFieldNumber = 7;

	[Token(Token = "0x4002302")]
	[FieldOffset(Offset = "0x30")]
	private int temporary_;

	[Token(Token = "0x17001602")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterCharacteristicDetailedUsable> Parser
	{
		[Token(Token = "0x60066AE")]
		[Address(RVA = "0xBA2D90", Offset = "0xBA2190", VA = "0x180BA2D90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001603")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60066AF")]
		[Address(RVA = "0xBA2CE0", Offset = "0xBA20E0", VA = "0x180BA2CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001604")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60066B0")]
		[Address(RVA = "0xBA2DE0", Offset = "0xBA21E0", VA = "0x180BA2DE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001605")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Base
	{
		[Token(Token = "0x60066B4")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60066B5")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001606")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Additional
	{
		[Token(Token = "0x60066B6")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60066B7")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001607")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ObjectsAndMountBonus
	{
		[Token(Token = "0x60066B8")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60066B9")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17001608")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int AlignmentGiftBonus
	{
		[Token(Token = "0x60066BA")]
		[Address(RVA = "0x87D140", Offset = "0x87C540", VA = "0x18087D140")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60066BB")]
		[Address(RVA = "0x9342C0", Offset = "0x9336C0", VA = "0x1809342C0")]
		set
		{
		}
	}

	[Token(Token = "0x17001609")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ContextModification
	{
		[Token(Token = "0x60066BC")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60066BD")]
		[Address(RVA = "0x934340", Offset = "0x933740", VA = "0x180934340")]
		set
		{
		}
	}

	[Token(Token = "0x1700160A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Used
	{
		[Token(Token = "0x60066BE")]
		[Address(RVA = "0x95FBF0", Offset = "0x95EFF0", VA = "0x18095FBF0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60066BF")]
		[Address(RVA = "0x960010", Offset = "0x95F410", VA = "0x180960010")]
		set
		{
		}
	}

	[Token(Token = "0x1700160B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Temporary
	{
		[Token(Token = "0x60066C0")]
		[Address(RVA = "0x875C10", Offset = "0x875010", VA = "0x180875C10")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60066C1")]
		[Address(RVA = "0x947120", Offset = "0x946520", VA = "0x180947120")]
		set
		{
		}
	}

	[Token(Token = "0x60066B1")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCharacteristicDetailedUsable()
	{
	}

	[Token(Token = "0x60066B2")]
	[Address(RVA = "0xA4B4A0", Offset = "0xA4A8A0", VA = "0x180A4B4A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCharacteristicDetailedUsable(CharacterCharacteristicDetailedUsable other)
	{
	}

	[Token(Token = "0x60066B3")]
	[Address(RVA = "0xBA2A20", Offset = "0xBA1E20", VA = "0x180BA2A20", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCharacteristicDetailedUsable Clone()
	{
		return null;
	}

	[Token(Token = "0x60066C2")]
	[Address(RVA = "0xBA2AC0", Offset = "0xBA1EC0", VA = "0x180BA2AC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60066C3")]
	[Address(RVA = "0xA4B140", Offset = "0xA4A540", VA = "0x180A4B140", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterCharacteristicDetailedUsable other)
	{
		return default(bool);
	}

	[Token(Token = "0x60066C4")]
	[Address(RVA = "0xA4B1A0", Offset = "0xA4A5A0", VA = "0x180A4B1A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60066C5")]
	[Address(RVA = "0xBA2B80", Offset = "0xBA1F80", VA = "0x180BA2B80", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60066C6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60066C7")]
	[Address(RVA = "0xA4B760", Offset = "0xA4AB60", VA = "0x180A4B760", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60066C8")]
	[Address(RVA = "0xBA2890", Offset = "0xBA1C90", VA = "0x180BA2890", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60066C9")]
	[Address(RVA = "0xA4B2B0", Offset = "0xA4A6B0", VA = "0x180A4B2B0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CharacterCharacteristicDetailedUsable other)
	{
	}

	[Token(Token = "0x60066CA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60066CB")]
	[Address(RVA = "0xA4B610", Offset = "0xA4AA10", VA = "0x180A4B610", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
