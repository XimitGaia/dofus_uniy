using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x2000334")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class DisplayNumericalValuePaddockEvent : IMessage<DisplayNumericalValuePaddockEvent>, IMessage, IEquatable<DisplayNumericalValuePaddockEvent>, IDeepCloneable<DisplayNumericalValuePaddockEvent>, IBufferMessage
{
	[Token(Token = "0x4000B10")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<DisplayNumericalValuePaddockEvent> _parser;

	[Token(Token = "0x4000B11")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B12")]
	public const int MountIdFieldNumber = 1;

	[Token(Token = "0x4000B13")]
	[FieldOffset(Offset = "0x18")]
	private int mountId_;

	[Token(Token = "0x4000B14")]
	public const int ValueFieldNumber = 2;

	[Token(Token = "0x4000B15")]
	[FieldOffset(Offset = "0x1C")]
	private int value_;

	[Token(Token = "0x4000B16")]
	public const int TypeFieldNumber = 3;

	[Token(Token = "0x4000B17")]
	[FieldOffset(Offset = "0x20")]
	private MountCharacteristic type_;

	[Token(Token = "0x17000718")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<DisplayNumericalValuePaddockEvent> Parser
	{
		[Token(Token = "0x600211E")]
		[Address(RVA = "0x969EF0", Offset = "0x9692F0", VA = "0x180969EF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000719")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600211F")]
		[Address(RVA = "0x969E40", Offset = "0x969240", VA = "0x180969E40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700071A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002120")]
		[Address(RVA = "0x969FE0", Offset = "0x9693E0", VA = "0x180969FE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700071B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MountId
	{
		[Token(Token = "0x6002124")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002125")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x1700071C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Value
	{
		[Token(Token = "0x6002126")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002127")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x1700071D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountCharacteristic Type
	{
		[Token(Token = "0x6002128")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(MountCharacteristic);
		}
		[Token(Token = "0x6002129")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6002121")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DisplayNumericalValuePaddockEvent()
	{
	}

	[Token(Token = "0x6002122")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DisplayNumericalValuePaddockEvent(DisplayNumericalValuePaddockEvent other)
	{
	}

	[Token(Token = "0x6002123")]
	[Address(RVA = "0x969B10", Offset = "0x968F10", VA = "0x180969B10", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public DisplayNumericalValuePaddockEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600212A")]
	[Address(RVA = "0x969BA0", Offset = "0x968FA0", VA = "0x180969BA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600212B")]
	[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(DisplayNumericalValuePaddockEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600212C")]
	[Address(RVA = "0x969C40", Offset = "0x969040", VA = "0x180969C40", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600212D")]
	[Address(RVA = "0x969CE0", Offset = "0x9690E0", VA = "0x180969CE0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600212E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600212F")]
	[Address(RVA = "0x969F40", Offset = "0x969340", VA = "0x180969F40", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002130")]
	[Address(RVA = "0x969A30", Offset = "0x968E30", VA = "0x180969A30", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002131")]
	[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(DisplayNumericalValuePaddockEvent other)
	{
	}

	[Token(Token = "0x6002132")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002133")]
	[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
