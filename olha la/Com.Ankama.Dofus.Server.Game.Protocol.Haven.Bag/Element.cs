using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x200044D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class Element : IMessage<Element>, IMessage, IEquatable<Element>, IDeepCloneable<Element>, IBufferMessage
{
	[Token(Token = "0x4000ED6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<Element> _parser;

	[Token(Token = "0x4000ED7")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000ED8")]
	public const int CellIdFieldNumber = 1;

	[Token(Token = "0x4000ED9")]
	[FieldOffset(Offset = "0x18")]
	private int cellId_;

	[Token(Token = "0x4000EDA")]
	public const int ElementIdFieldNumber = 2;

	[Token(Token = "0x4000EDB")]
	[FieldOffset(Offset = "0x1C")]
	private int elementId_;

	[Token(Token = "0x4000EDC")]
	public const int OrientationFieldNumber = 3;

	[Token(Token = "0x4000EDD")]
	[FieldOffset(Offset = "0x20")]
	private int orientation_;

	[Token(Token = "0x170009AD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<Element> Parser
	{
		[Token(Token = "0x6002D4F")]
		[Address(RVA = "0x9B1270", Offset = "0x9B0670", VA = "0x1809B1270")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009AE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002D50")]
		[Address(RVA = "0x9B11C0", Offset = "0x9B05C0", VA = "0x1809B11C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009AF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002D51")]
		[Address(RVA = "0x9B12C0", Offset = "0x9B06C0", VA = "0x1809B12C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170009B0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CellId
	{
		[Token(Token = "0x6002D55")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002D56")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170009B1")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ElementId
	{
		[Token(Token = "0x6002D57")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002D58")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x170009B2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int Orientation
	{
		[Token(Token = "0x6002D59")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002D5A")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6002D52")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Element()
	{
	}

	[Token(Token = "0x6002D53")]
	[Address(RVA = "0x939530", Offset = "0x938930", VA = "0x180939530")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Element(Element other)
	{
	}

	[Token(Token = "0x6002D54")]
	[Address(RVA = "0x9B0F30", Offset = "0x9B0330", VA = "0x1809B0F30", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Element Clone()
	{
		return null;
	}

	[Token(Token = "0x6002D5B")]
	[Address(RVA = "0x9B0FC0", Offset = "0x9B03C0", VA = "0x1809B0FC0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D5C")]
	[Address(RVA = "0x947820", Offset = "0x946C20", VA = "0x180947820", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(Element other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D5D")]
	[Address(RVA = "0x977E40", Offset = "0x977240", VA = "0x180977E40", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002D5E")]
	[Address(RVA = "0x9B1060", Offset = "0x9B0460", VA = "0x1809B1060", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002D5F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002D60")]
	[Address(RVA = "0x978140", Offset = "0x977540", VA = "0x180978140", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002D61")]
	[Address(RVA = "0x9B0E50", Offset = "0x9B0250", VA = "0x1809B0E50", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002D62")]
	[Address(RVA = "0x947910", Offset = "0x946D10", VA = "0x180947910", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(Element other)
	{
	}

	[Token(Token = "0x6002D63")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002D64")]
	[Address(RVA = "0x947BE0", Offset = "0x946FE0", VA = "0x180947BE0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
