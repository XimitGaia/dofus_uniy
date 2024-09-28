using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Server;

[Token(Token = "0x2000154")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ServerExperienceModifierEvent : IMessage<ServerExperienceModifierEvent>, IMessage, IEquatable<ServerExperienceModifierEvent>, IDeepCloneable<ServerExperienceModifierEvent>, IBufferMessage
{
	[Token(Token = "0x400048B")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ServerExperienceModifierEvent> _parser;

	[Token(Token = "0x400048C")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400048D")]
	public const int ExperiencePercentageFieldNumber = 1;

	[Token(Token = "0x400048E")]
	[FieldOffset(Offset = "0x18")]
	private int experiencePercentage_;

	[Token(Token = "0x170002D4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ServerExperienceModifierEvent> Parser
	{
		[Token(Token = "0x6000D33")]
		[Address(RVA = "0xC53730", Offset = "0xC52B30", VA = "0x180C53730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000D34")]
		[Address(RVA = "0xC53680", Offset = "0xC52A80", VA = "0x180C53680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000D35")]
		[Address(RVA = "0xC53780", Offset = "0xC52B80", VA = "0x180C53780", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002D7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int ExperiencePercentage
	{
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000D36")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ServerExperienceModifierEvent()
	{
	}

	[Token(Token = "0x6000D37")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerExperienceModifierEvent(ServerExperienceModifierEvent other)
	{
	}

	[Token(Token = "0x6000D38")]
	[Address(RVA = "0xC53410", Offset = "0xC52810", VA = "0x180C53410", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public ServerExperienceModifierEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000D3B")]
	[Address(RVA = "0xC53490", Offset = "0xC52890", VA = "0x180C53490", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D3C")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ServerExperienceModifierEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D3D")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000D3E")]
	[Address(RVA = "0xC53520", Offset = "0xC52920", VA = "0x180C53520", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000D3F")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000D40")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000D41")]
	[Address(RVA = "0xC53380", Offset = "0xC52780", VA = "0x180C53380", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000D42")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ServerExperienceModifierEvent other)
	{
	}

	[Token(Token = "0x6000D43")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000D44")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
