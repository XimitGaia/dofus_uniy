using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application;

[Token(Token = "0x200050F")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildApplicationModifiedEvent : IMessage<GuildApplicationModifiedEvent>, IMessage, IEquatable<GuildApplicationModifiedEvent>, IDeepCloneable<GuildApplicationModifiedEvent>, IBufferMessage
{
	[Token(Token = "0x4001138")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildApplicationModifiedEvent> _parser;

	[Token(Token = "0x4001139")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400113A")]
	public const int ApplicationFieldNumber = 1;

	[Token(Token = "0x400113B")]
	[FieldOffset(Offset = "0x18")]
	private SocialApplicationInformation application_;

	[Token(Token = "0x400113C")]
	public const int StateFieldNumber = 2;

	[Token(Token = "0x400113D")]
	[FieldOffset(Offset = "0x20")]
	private SocialApplicationState state_;

	[Token(Token = "0x400113E")]
	public const int PlayerIdFieldNumber = 3;

	[Token(Token = "0x400113F")]
	[FieldOffset(Offset = "0x28")]
	private long playerId_;

	[Token(Token = "0x17000B5A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildApplicationModifiedEvent> Parser
	{
		[Token(Token = "0x6003586")]
		[Address(RVA = "0x9FFA10", Offset = "0x9FEE10", VA = "0x1809FFA10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B5B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003587")]
		[Address(RVA = "0x9FF960", Offset = "0x9FED60", VA = "0x1809FF960")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B5C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003588")]
		[Address(RVA = "0x9FFC40", Offset = "0x9FF040", VA = "0x1809FFC40", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B5D")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialApplicationInformation Application
	{
		[Token(Token = "0x600358C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600358D")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000B5E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public SocialApplicationState State
	{
		[Token(Token = "0x600358E")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(SocialApplicationState);
		}
		[Token(Token = "0x600358F")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x17000B5F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public long PlayerId
	{
		[Token(Token = "0x6003590")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6003591")]
		[Address(RVA = "0x972C70", Offset = "0x972070", VA = "0x180972C70")]
		set
		{
		}
	}

	[Token(Token = "0x6003589")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationModifiedEvent()
	{
	}

	[Token(Token = "0x600358A")]
	[Address(RVA = "0x9FF8E0", Offset = "0x9FECE0", VA = "0x1809FF8E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildApplicationModifiedEvent(GuildApplicationModifiedEvent other)
	{
	}

	[Token(Token = "0x600358B")]
	[Address(RVA = "0x9FF400", Offset = "0x9FE800", VA = "0x1809FF400", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationModifiedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003592")]
	[Address(RVA = "0x9FF4B0", Offset = "0x9FE8B0", VA = "0x1809FF4B0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003593")]
	[Address(RVA = "0x9FF570", Offset = "0x9FE970", VA = "0x1809FF570", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildApplicationModifiedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003594")]
	[Address(RVA = "0x9FF5F0", Offset = "0x9FE9F0", VA = "0x1809FF5F0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003595")]
	[Address(RVA = "0x9FF780", Offset = "0x9FEB80", VA = "0x1809FF780", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003596")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003597")]
	[Address(RVA = "0x9FFBA0", Offset = "0x9FEFA0", VA = "0x1809FFBA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003598")]
	[Address(RVA = "0x9FF310", Offset = "0x9FE710", VA = "0x1809FF310", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003599")]
	[Address(RVA = "0x9FF6A0", Offset = "0x9FEAA0", VA = "0x1809FF6A0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildApplicationModifiedEvent other)
	{
	}

	[Token(Token = "0x600359A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600359B")]
	[Address(RVA = "0x9FFA60", Offset = "0x9FEE60", VA = "0x1809FFA60", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
