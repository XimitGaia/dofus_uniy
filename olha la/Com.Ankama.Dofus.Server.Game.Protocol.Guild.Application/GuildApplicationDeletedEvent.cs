using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application;

[Token(Token = "0x2000504")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildApplicationDeletedEvent : IMessage<GuildApplicationDeletedEvent>, IMessage, IEquatable<GuildApplicationDeletedEvent>, IDeepCloneable<GuildApplicationDeletedEvent>, IBufferMessage
{
	[Token(Token = "0x4001114")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildApplicationDeletedEvent> _parser;

	[Token(Token = "0x4001115")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001116")]
	public const int DeletedFieldNumber = 1;

	[Token(Token = "0x4001117")]
	[FieldOffset(Offset = "0x18")]
	private bool deleted_;

	[Token(Token = "0x17000B41")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildApplicationDeletedEvent> Parser
	{
		[Token(Token = "0x600350F")]
		[Address(RVA = "0x9E3770", Offset = "0x9E2B70", VA = "0x1809E3770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B42")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003510")]
		[Address(RVA = "0x9E36C0", Offset = "0x9E2AC0", VA = "0x1809E36C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B43")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003511")]
		[Address(RVA = "0x9E37C0", Offset = "0x9E2BC0", VA = "0x1809E37C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B44")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Deleted
	{
		[Token(Token = "0x6003515")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003516")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6003512")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationDeletedEvent()
	{
	}

	[Token(Token = "0x6003513")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildApplicationDeletedEvent(GuildApplicationDeletedEvent other)
	{
	}

	[Token(Token = "0x6003514")]
	[Address(RVA = "0x9E33B0", Offset = "0x9E27B0", VA = "0x1809E33B0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationDeletedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6003517")]
	[Address(RVA = "0x9E3430", Offset = "0x9E2830", VA = "0x1809E3430", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003518")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildApplicationDeletedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003519")]
	[Address(RVA = "0x9E34C0", Offset = "0x9E28C0", VA = "0x1809E34C0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600351A")]
	[Address(RVA = "0x9E3560", Offset = "0x9E2960", VA = "0x1809E3560", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600351B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600351C")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600351D")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600351E")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildApplicationDeletedEvent other)
	{
	}

	[Token(Token = "0x600351F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003520")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
