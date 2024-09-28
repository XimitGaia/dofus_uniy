using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x2000795")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContextRefreshEntityLookEvent : IMessage<ContextRefreshEntityLookEvent>, IMessage, IEquatable<ContextRefreshEntityLookEvent>, IDeepCloneable<ContextRefreshEntityLookEvent>, IBufferMessage
{
	[Token(Token = "0x4001A65")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContextRefreshEntityLookEvent> _parser;

	[Token(Token = "0x4001A66")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A67")]
	public const int EntityIdFieldNumber = 1;

	[Token(Token = "0x4001A68")]
	[FieldOffset(Offset = "0x18")]
	private long entityId_;

	[Token(Token = "0x4001A69")]
	public const int LookFieldNumber = 2;

	[Token(Token = "0x4001A6A")]
	[FieldOffset(Offset = "0x20")]
	private EntityLook look_;

	[Token(Token = "0x1700113A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ContextRefreshEntityLookEvent> Parser
	{
		[Token(Token = "0x60050AD")]
		[Address(RVA = "0xAD4220", Offset = "0xAD3620", VA = "0x180AD4220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700113B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60050AE")]
		[Address(RVA = "0xAD4170", Offset = "0xAD3570", VA = "0x180AD4170")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700113C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60050AF")]
		[Address(RVA = "0xAD4390", Offset = "0xAD3790", VA = "0x180AD4390", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700113D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long EntityId
	{
		[Token(Token = "0x60050B3")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x60050B4")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x1700113E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public EntityLook Look
	{
		[Token(Token = "0x60050B5")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x60050B6")]
		[Address(RVA = "0x7F0090", Offset = "0x7EF490", VA = "0x1807F0090")]
		set
		{
		}
	}

	[Token(Token = "0x60050B0")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContextRefreshEntityLookEvent()
	{
	}

	[Token(Token = "0x60050B1")]
	[Address(RVA = "0xA28300", Offset = "0xA27700", VA = "0x180A28300")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextRefreshEntityLookEvent(ContextRefreshEntityLookEvent other)
	{
	}

	[Token(Token = "0x60050B2")]
	[Address(RVA = "0xAD3DD0", Offset = "0xAD31D0", VA = "0x180AD3DD0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextRefreshEntityLookEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60050B7")]
	[Address(RVA = "0xAD3E70", Offset = "0xAD3270", VA = "0x180AD3E70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60050B8")]
	[Address(RVA = "0x953270", Offset = "0x952670", VA = "0x180953270", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContextRefreshEntityLookEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60050B9")]
	[Address(RVA = "0x9533A0", Offset = "0x9527A0", VA = "0x1809533A0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60050BA")]
	[Address(RVA = "0xAD4010", Offset = "0xAD3410", VA = "0x180AD4010", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60050BB")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60050BC")]
	[Address(RVA = "0x953910", Offset = "0x952D10", VA = "0x180953910", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60050BD")]
	[Address(RVA = "0xAD3D10", Offset = "0xAD3110", VA = "0x180AD3D10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60050BE")]
	[Address(RVA = "0xAD3F30", Offset = "0xAD3330", VA = "0x180AD3F30", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContextRefreshEntityLookEvent other)
	{
	}

	[Token(Token = "0x60050BF")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60050C0")]
	[Address(RVA = "0xAD4270", Offset = "0xAD3670", VA = "0x180AD4270", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
