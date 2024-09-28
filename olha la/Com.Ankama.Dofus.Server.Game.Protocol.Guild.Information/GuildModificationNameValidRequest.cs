using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x200048E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildModificationNameValidRequest : IMessage<GuildModificationNameValidRequest>, IMessage, IEquatable<GuildModificationNameValidRequest>, IDeepCloneable<GuildModificationNameValidRequest>, IBufferMessage
{
	[Token(Token = "0x4000FA1")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildModificationNameValidRequest> _parser;

	[Token(Token = "0x4000FA2")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000FA3")]
	public const int NameFieldNumber = 1;

	[Token(Token = "0x4000FA4")]
	[FieldOffset(Offset = "0x18")]
	private string name_;

	[Token(Token = "0x17000A35")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<GuildModificationNameValidRequest> Parser
	{
		[Token(Token = "0x6002FE2")]
		[Address(RVA = "0x9D95B0", Offset = "0x9D89B0", VA = "0x1809D95B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A36")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002FE3")]
		[Address(RVA = "0x9D9500", Offset = "0x9D8900", VA = "0x1809D9500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A37")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002FE4")]
		[Address(RVA = "0x9D96C0", Offset = "0x9D8AC0", VA = "0x1809D96C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A38")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Name
	{
		[Token(Token = "0x6002FE8")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002FE9")]
		[Address(RVA = "0x9D97A0", Offset = "0x9D8BA0", VA = "0x1809D97A0")]
		set
		{
		}
	}

	[Token(Token = "0x6002FE5")]
	[Address(RVA = "0x9D9410", Offset = "0x9D8810", VA = "0x1809D9410")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildModificationNameValidRequest()
	{
	}

	[Token(Token = "0x6002FE6")]
	[Address(RVA = "0x9D9460", Offset = "0x9D8860", VA = "0x1809D9460")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildModificationNameValidRequest(GuildModificationNameValidRequest other)
	{
	}

	[Token(Token = "0x6002FE7")]
	[Address(RVA = "0x9D90D0", Offset = "0x9D84D0", VA = "0x1809D90D0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildModificationNameValidRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002FEA")]
	[Address(RVA = "0x9D91A0", Offset = "0x9D85A0", VA = "0x1809D91A0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002FEB")]
	[Address(RVA = "0x91CE00", Offset = "0x91C200", VA = "0x18091CE00", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(GuildModificationNameValidRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002FEC")]
	[Address(RVA = "0x91CF20", Offset = "0x91C320", VA = "0x18091CF20", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002FED")]
	[Address(RVA = "0x9D92B0", Offset = "0x9D86B0", VA = "0x1809D92B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002FEE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002FEF")]
	[Address(RVA = "0x91D400", Offset = "0x91C800", VA = "0x18091D400", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002FF0")]
	[Address(RVA = "0x9D9040", Offset = "0x9D8440", VA = "0x1809D9040", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002FF1")]
	[Address(RVA = "0x9D9250", Offset = "0x9D8650", VA = "0x1809D9250", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(GuildModificationNameValidRequest other)
	{
	}

	[Token(Token = "0x6002FF2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002FF3")]
	[Address(RVA = "0x9D9600", Offset = "0x9D8A00", VA = "0x1809D9600", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
