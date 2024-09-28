using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004A0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildMotdSetRequest : IMessage<GuildMotdSetRequest>, IMessage, IEquatable<GuildMotdSetRequest>, IDeepCloneable<GuildMotdSetRequest>, IBufferMessage
{
	[Token(Token = "0x4000FD2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildMotdSetRequest> _parser;

	[Token(Token = "0x4000FD3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FD4")]
	public const int ContentFieldNumber = 1;

	[Token(Token = "0x4000FD5")]
	[FieldOffset(Offset = "0x18")]
	private string content_;

	[Token(Token = "0x17000A5B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildMotdSetRequest> Parser
	{
		[Token(Token = "0x60030AC")]
		[Address(RVA = "0x9DB380", Offset = "0x9DA780", VA = "0x1809DB380")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A5C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60030AD")]
		[Address(RVA = "0x9DB2D0", Offset = "0x9DA6D0", VA = "0x1809DB2D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A5D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60030AE")]
		[Address(RVA = "0x9DB490", Offset = "0x9DA890", VA = "0x1809DB490", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A5E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string Content
	{
		[Token(Token = "0x60030B2")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60030B3")]
		[Address(RVA = "0x9DB570", Offset = "0x9DA970", VA = "0x1809DB570")]
		set
		{
		}
	}

	[Token(Token = "0x60030AF")]
	[Address(RVA = "0x9DB280", Offset = "0x9DA680", VA = "0x1809DB280")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildMotdSetRequest()
	{
	}

	[Token(Token = "0x60030B0")]
	[Address(RVA = "0x9DB1E0", Offset = "0x9DA5E0", VA = "0x1809DB1E0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildMotdSetRequest(GuildMotdSetRequest other)
	{
	}

	[Token(Token = "0x60030B1")]
	[Address(RVA = "0x9DAEA0", Offset = "0x9DA2A0", VA = "0x1809DAEA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildMotdSetRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60030B4")]
	[Address(RVA = "0x9DAF70", Offset = "0x9DA370", VA = "0x1809DAF70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60030B5")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildMotdSetRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60030B6")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60030B7")]
	[Address(RVA = "0x9DB080", Offset = "0x9DA480", VA = "0x1809DB080", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60030B8")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60030B9")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60030BA")]
	[Address(RVA = "0x9DAE10", Offset = "0x9DA210", VA = "0x1809DAE10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60030BB")]
	[Address(RVA = "0x9DB020", Offset = "0x9DA420", VA = "0x1809DB020", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildMotdSetRequest other)
	{
	}

	[Token(Token = "0x60030BC")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60030BD")]
	[Address(RVA = "0x9DB3D0", Offset = "0x9DA7D0", VA = "0x1809DB3D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
