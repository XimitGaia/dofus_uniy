using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Element;

[Token(Token = "0x200074E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class LockableShowCodeDialogEvent : IMessage<LockableShowCodeDialogEvent>, IMessage, IEquatable<LockableShowCodeDialogEvent>, IDeepCloneable<LockableShowCodeDialogEvent>, IBufferMessage
{
	[Token(Token = "0x200074F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000750")]
		public enum Action
		{
			[Token(Token = "0x40019B7")]
			[OriginalName("CHANGE")]
			Change,
			[Token(Token = "0x40019B8")]
			[OriginalName("USE")]
			Use
		}
	}

	[Token(Token = "0x40019B0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<LockableShowCodeDialogEvent> _parser;

	[Token(Token = "0x40019B1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40019B2")]
	public const int ActionFieldNumber = 1;

	[Token(Token = "0x40019B3")]
	[FieldOffset(Offset = "0x18")]
	private Types.Action action_;

	[Token(Token = "0x40019B4")]
	public const int CodeSizeFieldNumber = 2;

	[Token(Token = "0x40019B5")]
	[FieldOffset(Offset = "0x1C")]
	private int codeSize_;

	[Token(Token = "0x170010C7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<LockableShowCodeDialogEvent> Parser
	{
		[Token(Token = "0x6004E60")]
		[Address(RVA = "0xAC25E0", Offset = "0xAC19E0", VA = "0x180AC25E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010C8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6004E61")]
		[Address(RVA = "0xAC2530", Offset = "0xAC1930", VA = "0x180AC2530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010C9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6004E62")]
		[Address(RVA = "0xAC2630", Offset = "0xAC1A30", VA = "0x180AC2630", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170010CA")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.Action Action
	{
		[Token(Token = "0x6004E66")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.Action);
		}
		[Token(Token = "0x6004E67")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170010CB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CodeSize
	{
		[Token(Token = "0x6004E68")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6004E69")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x6004E63")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public LockableShowCodeDialogEvent()
	{
	}

	[Token(Token = "0x6004E64")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockableShowCodeDialogEvent(LockableShowCodeDialogEvent other)
	{
	}

	[Token(Token = "0x6004E65")]
	[Address(RVA = "0xAC22B0", Offset = "0xAC16B0", VA = "0x180AC22B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public LockableShowCodeDialogEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6004E6A")]
	[Address(RVA = "0xAC2340", Offset = "0xAC1740", VA = "0x180AC2340", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E6B")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(LockableShowCodeDialogEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6004E6C")]
	[Address(RVA = "0x93AAA0", Offset = "0x939EA0", VA = "0x18093AAA0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6004E6D")]
	[Address(RVA = "0xAC23D0", Offset = "0xAC17D0", VA = "0x180AC23D0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6004E6E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6004E6F")]
	[Address(RVA = "0x93AED0", Offset = "0x93A2D0", VA = "0x18093AED0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6004E70")]
	[Address(RVA = "0xAC21F0", Offset = "0xAC15F0", VA = "0x180AC21F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6004E71")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(LockableShowCodeDialogEvent other)
	{
	}

	[Token(Token = "0x6004E72")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6004E73")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
