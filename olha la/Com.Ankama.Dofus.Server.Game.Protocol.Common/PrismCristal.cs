using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Common;

[Token(Token = "0x2000AFC")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PrismCristal : IMessage<PrismCristal>, IMessage, IEquatable<PrismCristal>, IDeepCloneable<PrismCristal>, IBufferMessage
{
	[Token(Token = "0x2000AFD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000AFE")]
		public enum PrismCristalType
		{
			[Token(Token = "0x4002893")]
			[OriginalName("NO_CRISTAL")]
			NoCristal,
			[Token(Token = "0x4002894")]
			[OriginalName("PROTECTIVE")]
			Protective,
			[Token(Token = "0x4002895")]
			[OriginalName("INHIBITOR")]
			Inhibitor
		}
	}

	[Token(Token = "0x400288C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PrismCristal> _parser;

	[Token(Token = "0x400288D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400288E")]
	public const int CristalObjectFieldNumber = 1;

	[Token(Token = "0x400288F")]
	[FieldOffset(Offset = "0x18")]
	private ObjectItemInventory cristalObject_;

	[Token(Token = "0x4002890")]
	public const int TypeFieldNumber = 2;

	[Token(Token = "0x4002891")]
	[FieldOffset(Offset = "0x20")]
	private Types.PrismCristalType type_;

	[Token(Token = "0x17001944")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PrismCristal> Parser
	{
		[Token(Token = "0x6007356")]
		[Address(RVA = "0xBFC420", Offset = "0xBFB820", VA = "0x180BFC420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001945")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6007357")]
		[Address(RVA = "0xBFC370", Offset = "0xBFB770", VA = "0x180BFC370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001946")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6007358")]
		[Address(RVA = "0xBFC590", Offset = "0xBFB990", VA = "0x180BFC590", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001947")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ObjectItemInventory CristalObject
	{
		[Token(Token = "0x600735C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600735D")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001948")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.PrismCristalType Type
	{
		[Token(Token = "0x600735E")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(Types.PrismCristalType);
		}
		[Token(Token = "0x600735F")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6007359")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismCristal()
	{
	}

	[Token(Token = "0x600735A")]
	[Address(RVA = "0x98AF60", Offset = "0x98A360", VA = "0x18098AF60")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismCristal(PrismCristal other)
	{
	}

	[Token(Token = "0x600735B")]
	[Address(RVA = "0xBFBFE0", Offset = "0xBFB3E0", VA = "0x180BFBFE0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PrismCristal Clone()
	{
		return null;
	}

	[Token(Token = "0x6007360")]
	[Address(RVA = "0xBFC090", Offset = "0xBFB490", VA = "0x180BFC090", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007361")]
	[Address(RVA = "0x98AC30", Offset = "0x98A030", VA = "0x18098AC30", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PrismCristal other)
	{
		return default(bool);
	}

	[Token(Token = "0x6007362")]
	[Address(RVA = "0x98ACA0", Offset = "0x98A0A0", VA = "0x18098ACA0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007363")]
	[Address(RVA = "0xBFC210", Offset = "0xBFB610", VA = "0x180BFC210", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6007364")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6007365")]
	[Address(RVA = "0x98B200", Offset = "0x98A600", VA = "0x18098B200", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6007366")]
	[Address(RVA = "0xBFBF20", Offset = "0xBFB320", VA = "0x180BFBF20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6007367")]
	[Address(RVA = "0xBFC140", Offset = "0xBFB540", VA = "0x180BFC140", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PrismCristal other)
	{
	}

	[Token(Token = "0x6007368")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6007369")]
	[Address(RVA = "0xBFC470", Offset = "0xBFB870", VA = "0x180BFC470", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
