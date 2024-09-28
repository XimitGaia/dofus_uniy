using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AB7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ShortcutCosmeticObject : IMessage<ShortcutCosmeticObject>, IMessage, IEquatable<ShortcutCosmeticObject>, IDeepCloneable<ShortcutCosmeticObject>, IBufferMessage
{
	[Token(Token = "0x4002731")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ShortcutCosmeticObject> _parser;

	[Token(Token = "0x4002732")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002733")]
	[FieldOffset(Offset = "0x18")]
	private int _hasBits0;

	[Token(Token = "0x4002734")]
	public const int ObjectGidFieldNumber = 1;

	[Token(Token = "0x4002735")]
	[FieldOffset(Offset = "0x1C")]
	private int objectGid_;

	[Token(Token = "0x4002736")]
	public const int SkinIdFieldNumber = 2;

	[Token(Token = "0x4002737")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int SkinIdDefaultValue;

	[Token(Token = "0x4002738")]
	[FieldOffset(Offset = "0x20")]
	private int skinId_;

	[Token(Token = "0x4002739")]
	public const int EnableFieldNumber = 3;

	[Token(Token = "0x400273A")]
	[FieldOffset(Offset = "0x24")]
	private bool enable_;

	[Token(Token = "0x17001873")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ShortcutCosmeticObject> Parser
	{
		[Token(Token = "0x6007028")]
		[Address(RVA = "0xBE8E10", Offset = "0xBE8210", VA = "0x180BE8E10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001874")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007029")]
		[Address(RVA = "0xBE8D60", Offset = "0xBE8160", VA = "0x180BE8D60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001875")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600702A")]
		[Address(RVA = "0xBE9090", Offset = "0xBE8490", VA = "0x180BE9090", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001876")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ObjectGid
	{
		[Token(Token = "0x600702E")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600702F")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x17001877")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int SkinId
	{
		[Token(Token = "0x6007030")]
		[Address(RVA = "0xBE8E60", Offset = "0xBE8260", VA = "0x180BE8E60")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007031")]
		[Address(RVA = "0x939960", Offset = "0x938D60", VA = "0x180939960")]
		set
		{
		}
	}

	[Token(Token = "0x17001878")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool HasSkinId
	{
		[Token(Token = "0x6007032")]
		[Address(RVA = "0x87E8D0", Offset = "0x87DCD0", VA = "0x18087E8D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001879")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Enable
	{
		[Token(Token = "0x6007034")]
		[Address(RVA = "0xA7E460", Offset = "0xA7D860", VA = "0x180A7E460")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007035")]
		[Address(RVA = "0xA7E710", Offset = "0xA7DB10", VA = "0x180A7E710")]
		set
		{
		}
	}

	[Token(Token = "0x600702B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutCosmeticObject()
	{
	}

	[Token(Token = "0x600702C")]
	[Address(RVA = "0xA7E300", Offset = "0xA7D700", VA = "0x180A7E300")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutCosmeticObject(ShortcutCosmeticObject other)
	{
	}

	[Token(Token = "0x600702D")]
	[Address(RVA = "0xBE8880", Offset = "0xBE7C80", VA = "0x180BE8880", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ShortcutCosmeticObject Clone()
	{
		return null;
	}

	[Token(Token = "0x6007033")]
	[Address(RVA = "0x92D290", Offset = "0x92C690", VA = "0x18092D290")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearSkinId()
	{
	}

	[Token(Token = "0x6007036")]
	[Address(RVA = "0xBE8910", Offset = "0xBE7D10", VA = "0x180BE8910", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007037")]
	[Address(RVA = "0xBE89D0", Offset = "0xBE7DD0", VA = "0x180BE89D0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ShortcutCosmeticObject other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007038")]
	[Address(RVA = "0xBE8A50", Offset = "0xBE7E50", VA = "0x180BE8A50", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007039")]
	[Address(RVA = "0xBE8BF0", Offset = "0xBE7FF0", VA = "0x180BE8BF0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600703A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600703B")]
	[Address(RVA = "0xBE8FB0", Offset = "0xBE83B0", VA = "0x180BE8FB0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600703C")]
	[Address(RVA = "0xBE8770", Offset = "0xBE7B70", VA = "0x180BE8770", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600703D")]
	[Address(RVA = "0xBE8B80", Offset = "0xBE7F80", VA = "0x180BE8B80", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ShortcutCosmeticObject other)
	{
	}

	[Token(Token = "0x600703E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600703F")]
	[Address(RVA = "0xBE8ED0", Offset = "0xBE82D0", VA = "0x180BE8ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
