using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Cosmetic;

[Token(Token = "0x2000C2D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class OutfitEntityLookChangedEvent : IMessage<OutfitEntityLookChangedEvent>, IMessage, IEquatable<OutfitEntityLookChangedEvent>, IDeepCloneable<OutfitEntityLookChangedEvent>, IBufferMessage
{
	[Token(Token = "0x4002D22")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<OutfitEntityLookChangedEvent> _parser;

	[Token(Token = "0x4002D23")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002D24")]
	public const int OutfitUuidFieldNumber = 1;

	[Token(Token = "0x4002D25")]
	[FieldOffset(Offset = "0x18")]
	private string outfitUuid_;

	[Token(Token = "0x4002D26")]
	public const int EntityLookFieldNumber = 2;

	[Token(Token = "0x4002D27")]
	[FieldOffset(Offset = "0x20")]
	private EntityLook entityLook_;

	[Token(Token = "0x17001C19")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<OutfitEntityLookChangedEvent> Parser
	{
		[Token(Token = "0x600801E")]
		[Address(RVA = "0xC61D40", Offset = "0xC61140", VA = "0x180C61D40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C1A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600801F")]
		[Address(RVA = "0xC61C90", Offset = "0xC61090", VA = "0x180C61C90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C1B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008020")]
		[Address(RVA = "0xC61ED0", Offset = "0xC612D0", VA = "0x180C61ED0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C1C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string OutfitUuid
	{
		[Token(Token = "0x6008024")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008025")]
		[Address(RVA = "0xC61FB0", Offset = "0xC613B0", VA = "0x180C61FB0")]
		set
		{
		}
	}

	[Token(Token = "0x17001C1D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public EntityLook EntityLook
	{
		[Token(Token = "0x6008026")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008027")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x6008021")]
	[Address(RVA = "0xC61C40", Offset = "0xC61040", VA = "0x180C61C40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEntityLookChangedEvent()
	{
	}

	[Token(Token = "0x6008022")]
	[Address(RVA = "0xC61B80", Offset = "0xC60F80", VA = "0x180C61B80")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public OutfitEntityLookChangedEvent(OutfitEntityLookChangedEvent other)
	{
	}

	[Token(Token = "0x6008023")]
	[Address(RVA = "0xC61780", Offset = "0xC60B80", VA = "0x180C61780", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public OutfitEntityLookChangedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6008028")]
	[Address(RVA = "0xC61870", Offset = "0xC60C70", VA = "0x180C61870", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008029")]
	[Address(RVA = "0x92F3E0", Offset = "0x92E7E0", VA = "0x18092F3E0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(OutfitEntityLookChangedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600802A")]
	[Address(RVA = "0x92F460", Offset = "0x92E860", VA = "0x18092F460", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600802B")]
	[Address(RVA = "0xC61A20", Offset = "0xC60E20", VA = "0x180C61A20", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600802C")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600802D")]
	[Address(RVA = "0x92FB90", Offset = "0x92EF90", VA = "0x18092FB90", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600802E")]
	[Address(RVA = "0xC616C0", Offset = "0xC60AC0", VA = "0x180C616C0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600802F")]
	[Address(RVA = "0xC61930", Offset = "0xC60D30", VA = "0x180C61930", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(OutfitEntityLookChangedEvent other)
	{
	}

	[Token(Token = "0x6008030")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008031")]
	[Address(RVA = "0xC61D90", Offset = "0xC61190", VA = "0x180C61D90", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
