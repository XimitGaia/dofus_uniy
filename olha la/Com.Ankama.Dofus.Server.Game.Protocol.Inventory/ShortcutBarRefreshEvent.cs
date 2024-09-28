using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003C7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShortcutBarRefreshEvent : IMessage<ShortcutBarRefreshEvent>, IMessage, IEquatable<ShortcutBarRefreshEvent>, IDeepCloneable<ShortcutBarRefreshEvent>, IBufferMessage
{
	[Token(Token = "0x4000CFA")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShortcutBarRefreshEvent> _parser;

	[Token(Token = "0x4000CFB")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CFC")]
	public const int BarTypeFieldNumber = 1;

	[Token(Token = "0x4000CFD")]
	[FieldOffset(Offset = "0x18")]
	private ShortcutBar barType_;

	[Token(Token = "0x4000CFE")]
	public const int ShortcutFieldNumber = 2;

	[Token(Token = "0x4000CFF")]
	[FieldOffset(Offset = "0x20")]
	private Shortcut shortcut_;

	[Token(Token = "0x1700086B")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ShortcutBarRefreshEvent> Parser
	{
		[Token(Token = "0x600276A")]
		[Address(RVA = "0x9977F0", Offset = "0x996BF0", VA = "0x1809977F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700086C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600276B")]
		[Address(RVA = "0x997740", Offset = "0x996B40", VA = "0x180997740")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700086D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600276C")]
		[Address(RVA = "0x997960", Offset = "0x996D60", VA = "0x180997960", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700086E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutBar BarType
	{
		[Token(Token = "0x6002770")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ShortcutBar);
		}
		[Token(Token = "0x6002771")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700086F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Shortcut Shortcut
	{
		[Token(Token = "0x6002772")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002773")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x600276D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarRefreshEvent()
	{
	}

	[Token(Token = "0x600276E")]
	[Address(RVA = "0x996470", Offset = "0x995870", VA = "0x180996470")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarRefreshEvent(ShortcutBarRefreshEvent other)
	{
	}

	[Token(Token = "0x600276F")]
	[Address(RVA = "0x9973C0", Offset = "0x9967C0", VA = "0x1809973C0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarRefreshEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002774")]
	[Address(RVA = "0x997460", Offset = "0x996860", VA = "0x180997460", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002775")]
	[Address(RVA = "0x940820", Offset = "0x93FC20", VA = "0x180940820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ShortcutBarRefreshEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002776")]
	[Address(RVA = "0x940940", Offset = "0x93FD40", VA = "0x180940940", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002777")]
	[Address(RVA = "0x9975E0", Offset = "0x9969E0", VA = "0x1809975E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002778")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002779")]
	[Address(RVA = "0x996700", Offset = "0x995B00", VA = "0x180996700", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600277A")]
	[Address(RVA = "0x997300", Offset = "0x996700", VA = "0x180997300", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600277B")]
	[Address(RVA = "0x997510", Offset = "0x996910", VA = "0x180997510", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ShortcutBarRefreshEvent other)
	{
	}

	[Token(Token = "0x600277C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600277D")]
	[Address(RVA = "0x997840", Offset = "0x996C40", VA = "0x180997840", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
