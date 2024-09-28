using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Guild.Information;

[Token(Token = "0x20004C0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class GuildPaddockRemovedEvent : IMessage<GuildPaddockRemovedEvent>, IMessage, IEquatable<GuildPaddockRemovedEvent>, IDeepCloneable<GuildPaddockRemovedEvent>, IBufferMessage
{
	[Token(Token = "0x4001044")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<GuildPaddockRemovedEvent> _parser;

	[Token(Token = "0x4001045")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001046")]
	public const int PaddockIdFieldNumber = 1;

	[Token(Token = "0x4001047")]
	[FieldOffset(Offset = "0x18")]
	private long paddockId_;

	[Token(Token = "0x17000AAA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<GuildPaddockRemovedEvent> Parser
	{
		[Token(Token = "0x6003226")]
		[Address(RVA = "0x9F6730", Offset = "0x9F5B30", VA = "0x1809F6730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AAB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6003227")]
		[Address(RVA = "0x9F6680", Offset = "0x9F5A80", VA = "0x1809F6680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AAC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6003228")]
		[Address(RVA = "0x9F6780", Offset = "0x9F5B80", VA = "0x1809F6780", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AAD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long PaddockId
	{
		[Token(Token = "0x600322C")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x600322D")]
		[Address(RVA = "0x918550", Offset = "0x917950", VA = "0x180918550")]
		set
		{
		}
	}

	[Token(Token = "0x6003229")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public GuildPaddockRemovedEvent()
	{
	}

	[Token(Token = "0x600322A")]
	[Address(RVA = "0x918220", Offset = "0x917620", VA = "0x180918220")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildPaddockRemovedEvent(GuildPaddockRemovedEvent other)
	{
	}

	[Token(Token = "0x600322B")]
	[Address(RVA = "0x9F6410", Offset = "0x9F5810", VA = "0x1809F6410", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public GuildPaddockRemovedEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600322E")]
	[Address(RVA = "0x9F6490", Offset = "0x9F5890", VA = "0x1809F6490", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600322F")]
	[Address(RVA = "0x917FC0", Offset = "0x9173C0", VA = "0x180917FC0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(GuildPaddockRemovedEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6003230")]
	[Address(RVA = "0x917FF0", Offset = "0x9173F0", VA = "0x180917FF0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6003231")]
	[Address(RVA = "0x9F6520", Offset = "0x9F5920", VA = "0x1809F6520", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6003232")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6003233")]
	[Address(RVA = "0x918410", Offset = "0x917810", VA = "0x180918410", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6003234")]
	[Address(RVA = "0x9F6380", Offset = "0x9F5780", VA = "0x1809F6380", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6003235")]
	[Address(RVA = "0x918070", Offset = "0x917470", VA = "0x180918070", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(GuildPaddockRemovedEvent other)
	{
	}

	[Token(Token = "0x6003236")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6003237")]
	[Address(RVA = "0x918370", Offset = "0x917770", VA = "0x180918370", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
