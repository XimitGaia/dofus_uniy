using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Inventory;

[Token(Token = "0x20003C3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class InventoryWeightEvent : IMessage<InventoryWeightEvent>, IMessage, IEquatable<InventoryWeightEvent>, IDeepCloneable<InventoryWeightEvent>, IBufferMessage
{
	[Token(Token = "0x4000CEB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<InventoryWeightEvent> _parser;

	[Token(Token = "0x4000CEC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000CED")]
	public const int InventoryWeightFieldNumber = 1;

	[Token(Token = "0x4000CEE")]
	[FieldOffset(Offset = "0x18")]
	private int inventoryWeight_;

	[Token(Token = "0x4000CEF")]
	public const int WeightMaxFieldNumber = 2;

	[Token(Token = "0x4000CF0")]
	[FieldOffset(Offset = "0x1C")]
	private int weightMax_;

	[Token(Token = "0x17000861")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<InventoryWeightEvent> Parser
	{
		[Token(Token = "0x600273B")]
		[Address(RVA = "0x989420", Offset = "0x988820", VA = "0x180989420")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000862")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600273C")]
		[Address(RVA = "0x989370", Offset = "0x988770", VA = "0x180989370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000863")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600273D")]
		[Address(RVA = "0x989470", Offset = "0x988870", VA = "0x180989470", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000864")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int InventoryWeight
	{
		[Token(Token = "0x6002741")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002742")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000865")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int WeightMax
	{
		[Token(Token = "0x6002743")]
		[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002744")]
		[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
		set
		{
		}
	}

	[Token(Token = "0x600273E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InventoryWeightEvent()
	{
	}

	[Token(Token = "0x600273F")]
	[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public InventoryWeightEvent(InventoryWeightEvent other)
	{
	}

	[Token(Token = "0x6002740")]
	[Address(RVA = "0x9890F0", Offset = "0x9884F0", VA = "0x1809890F0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public InventoryWeightEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002745")]
	[Address(RVA = "0x989180", Offset = "0x988580", VA = "0x180989180", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002746")]
	[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(InventoryWeightEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002747")]
	[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002748")]
	[Address(RVA = "0x989210", Offset = "0x988610", VA = "0x180989210", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002749")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600274A")]
	[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600274B")]
	[Address(RVA = "0x989030", Offset = "0x988430", VA = "0x180989030", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600274C")]
	[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(InventoryWeightEvent other)
	{
	}

	[Token(Token = "0x600274D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600274E")]
	[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
