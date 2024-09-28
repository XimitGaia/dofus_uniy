using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x2000382")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShortcutBarRemoveRequest : IMessage<ShortcutBarRemoveRequest>, IMessage, IEquatable<ShortcutBarRemoveRequest>, IDeepCloneable<ShortcutBarRemoveRequest>, IBufferMessage
{
	[Token(Token = "0x4000C1C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShortcutBarRemoveRequest> _parser;

	[Token(Token = "0x4000C1D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000C1E")]
	public const int BarTypeFieldNumber = 1;

	[Token(Token = "0x4000C1F")]
	[FieldOffset(Offset = "0x18")]
	private ShortcutBar barType_;

	[Token(Token = "0x4000C20")]
	public const int SlotIdFieldNumber = 2;

	[Token(Token = "0x4000C21")]
	[FieldOffset(Offset = "0x1C")]
	private int slotId_;

	[Token(Token = "0x170007CE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ShortcutBarRemoveRequest> Parser
	{
		[Token(Token = "0x600245E")]
		[Address(RVA = "0x997E30", Offset = "0x997230", VA = "0x180997E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007CF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600245F")]
		[Address(RVA = "0x997D80", Offset = "0x997180", VA = "0x180997D80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002460")]
		[Address(RVA = "0x997E80", Offset = "0x997280", VA = "0x180997E80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170007D1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBar BarType
	{
		[Token(Token = "0x6002464")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(ShortcutBar);
		}
		[Token(Token = "0x6002465")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170007D2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int SlotId
	{
		[Token(Token = "0x6002466")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002467")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6002461")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ShortcutBarRemoveRequest()
	{
	}

	[Token(Token = "0x6002462")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarRemoveRequest(ShortcutBarRemoveRequest other)
	{
	}

	[Token(Token = "0x6002463")]
	[Address(RVA = "0x997B00", Offset = "0x996F00", VA = "0x180997B00", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutBarRemoveRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002468")]
	[Address(RVA = "0x997B90", Offset = "0x996F90", VA = "0x180997B90", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002469")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(ShortcutBarRemoveRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600246A")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600246B")]
	[Address(RVA = "0x997C20", Offset = "0x997020", VA = "0x180997C20", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600246C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600246D")]
	[Address(RVA = "0x93AED0", Offset = "0x93A2D0", VA = "0x18093AED0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600246E")]
	[Address(RVA = "0x997A40", Offset = "0x996E40", VA = "0x180997A40", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600246F")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ShortcutBarRemoveRequest other)
	{
	}

	[Token(Token = "0x6002470")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002471")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
