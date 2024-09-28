using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Application;

[Token(Token = "0x2000502")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildApplicationPresenceRequest : IMessage<GuildApplicationPresenceRequest>, IMessage, IEquatable<GuildApplicationPresenceRequest>, IDeepCloneable<GuildApplicationPresenceRequest>, IBufferMessage
{
	[Token(Token = "0x4001111")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildApplicationPresenceRequest> _parser;

	[Token(Token = "0x4001112")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000B3E")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildApplicationPresenceRequest> Parser
	{
		[Token(Token = "0x60034FB")]
		[Address(RVA = "0x9E4E30", Offset = "0x9E4230", VA = "0x1809E4E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B3F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60034FC")]
		[Address(RVA = "0x9E4D80", Offset = "0x9E4180", VA = "0x1809E4D80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000B40")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60034FD")]
		[Address(RVA = "0x9E4E80", Offset = "0x9E4280", VA = "0x1809E4E80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60034FE")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationPresenceRequest()
	{
	}

	[Token(Token = "0x60034FF")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildApplicationPresenceRequest(GuildApplicationPresenceRequest other)
	{
	}

	[Token(Token = "0x6003500")]
	[Address(RVA = "0x9E4B20", Offset = "0x9E3F20", VA = "0x1809E4B20", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildApplicationPresenceRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6003501")]
	[Address(RVA = "0x9E4BA0", Offset = "0x9E3FA0", VA = "0x1809E4BA0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003502")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildApplicationPresenceRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003503")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003504")]
	[Address(RVA = "0x9E4C20", Offset = "0x9E4020", VA = "0x1809E4C20", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003505")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003506")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003507")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003508")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildApplicationPresenceRequest other)
	{
	}

	[Token(Token = "0x6003509")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600350A")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
