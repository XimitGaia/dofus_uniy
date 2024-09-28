using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character;

[Token(Token = "0x200087D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterCharacteristicUpgradeResultEvent : IMessage<CharacterCharacteristicUpgradeResultEvent>, IMessage, IEquatable<CharacterCharacteristicUpgradeResultEvent>, IDeepCloneable<CharacterCharacteristicUpgradeResultEvent>, IBufferMessage
{
	[Token(Token = "0x200087E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x200087F")]
		public enum CharacteristicUpgradeResult
		{
			[Token(Token = "0x4001D6C")]
			[OriginalName("NONE")]
			None,
			[Token(Token = "0x4001D6D")]
			[OriginalName("SUCCESS")]
			Success,
			[Token(Token = "0x4001D6E")]
			[OriginalName("GUEST")]
			Guest,
			[Token(Token = "0x4001D6F")]
			[OriginalName("IN_FIGHT")]
			InFight,
			[Token(Token = "0x4001D70")]
			[OriginalName("NOT_ENOUGH_POINT")]
			NotEnoughPoint
		}
	}

	[Token(Token = "0x4001D65")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterCharacteristicUpgradeResultEvent> _parser;

	[Token(Token = "0x4001D66")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D67")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x4001D68")]
	[FieldOffset(Offset = "0x18")]
	private Types.CharacteristicUpgradeResult result_;

	[Token(Token = "0x4001D69")]
	public const int PointsFieldNumber = 2;

	[Token(Token = "0x4001D6A")]
	[FieldOffset(Offset = "0x1C")]
	private int points_;

	[Token(Token = "0x17001334")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<CharacterCharacteristicUpgradeResultEvent> Parser
	{
		[Token(Token = "0x6005A37")]
		[Address(RVA = "0xB174D0", Offset = "0xB168D0", VA = "0x180B174D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001335")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005A38")]
		[Address(RVA = "0xB17420", Offset = "0xB16820", VA = "0x180B17420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001336")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005A39")]
		[Address(RVA = "0xB17520", Offset = "0xB16920", VA = "0x180B17520", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001337")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.CharacteristicUpgradeResult Result
	{
		[Token(Token = "0x6005A3D")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.CharacteristicUpgradeResult);
		}
		[Token(Token = "0x6005A3E")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17001338")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int Points
	{
		[Token(Token = "0x6005A3F")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005A40")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6005A3A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristicUpgradeResultEvent()
	{
	}

	[Token(Token = "0x6005A3B")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristicUpgradeResultEvent(CharacterCharacteristicUpgradeResultEvent other)
	{
	}

	[Token(Token = "0x6005A3C")]
	[Address(RVA = "0xB171A0", Offset = "0xB165A0", VA = "0x180B171A0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCharacteristicUpgradeResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005A41")]
	[Address(RVA = "0xB17230", Offset = "0xB16630", VA = "0x180B17230", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A42")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(CharacterCharacteristicUpgradeResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005A43")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005A44")]
	[Address(RVA = "0xB172C0", Offset = "0xB166C0", VA = "0x180B172C0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005A45")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005A46")]
	[Address(RVA = "0x93AED0", Offset = "0x93A2D0", VA = "0x18093AED0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005A47")]
	[Address(RVA = "0xB170E0", Offset = "0xB164E0", VA = "0x180B170E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005A48")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterCharacteristicUpgradeResultEvent other)
	{
	}

	[Token(Token = "0x6005A49")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005A4A")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
