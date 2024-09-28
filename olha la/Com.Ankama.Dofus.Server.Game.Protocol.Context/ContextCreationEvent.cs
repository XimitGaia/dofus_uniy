using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Context;

[Token(Token = "0x200078B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ContextCreationEvent : IMessage<ContextCreationEvent>, IMessage, IEquatable<ContextCreationEvent>, IDeepCloneable<ContextCreationEvent>, IBufferMessage
{
	[Token(Token = "0x200078C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x200078D")]
		public enum GameContext
		{
			[Token(Token = "0x4001A54")]
			[OriginalName("ROLE_PLAY")]
			RolePlay,
			[Token(Token = "0x4001A55")]
			[OriginalName("FIGHT")]
			Fight
		}
	}

	[Token(Token = "0x4001A4F")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ContextCreationEvent> _parser;

	[Token(Token = "0x4001A50")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001A51")]
	public const int ContextFieldNumber = 1;

	[Token(Token = "0x4001A52")]
	[FieldOffset(Offset = "0x18")]
	private Types.GameContext context_;

	[Token(Token = "0x1700112B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ContextCreationEvent> Parser
	{
		[Token(Token = "0x6005058")]
		[Address(RVA = "0xAD0DA0", Offset = "0xAD01A0", VA = "0x180AD0DA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700112C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005059")]
		[Address(RVA = "0xAD0CF0", Offset = "0xAD00F0", VA = "0x180AD0CF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700112D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600505A")]
		[Address(RVA = "0xAD0DF0", Offset = "0xAD01F0", VA = "0x180AD0DF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700112E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.GameContext Context
	{
		[Token(Token = "0x600505E")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(Types.GameContext);
		}
		[Token(Token = "0x600505F")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x600505B")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ContextCreationEvent()
	{
	}

	[Token(Token = "0x600505C")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContextCreationEvent(ContextCreationEvent other)
	{
	}

	[Token(Token = "0x600505D")]
	[Address(RVA = "0xAD0A80", Offset = "0xACFE80", VA = "0x180AD0A80", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ContextCreationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6005060")]
	[Address(RVA = "0xAD0B00", Offset = "0xACFF00", VA = "0x180AD0B00", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005061")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ContextCreationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005062")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005063")]
	[Address(RVA = "0xAD0B90", Offset = "0xACFF90", VA = "0x180AD0B90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005064")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005065")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005066")]
	[Address(RVA = "0xAD09F0", Offset = "0xACFDF0", VA = "0x180AD09F0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005067")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ContextCreationEvent other)
	{
	}

	[Token(Token = "0x6005068")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005069")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
