using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Moderation;

[Token(Token = "0x2000339")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PopupWarningEvent : IMessage<PopupWarningEvent>, IMessage, IEquatable<PopupWarningEvent>, IDeepCloneable<PopupWarningEvent>, IBufferMessage
{
	[Token(Token = "0x4000B1D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PopupWarningEvent> _parser;

	[Token(Token = "0x4000B1E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B1F")]
	public const int LockDurationFieldNumber = 1;

	[Token(Token = "0x4000B20")]
	[FieldOffset(Offset = "0x18")]
	private int lockDuration_;

	[Token(Token = "0x4000B21")]
	public const int AuthorFieldNumber = 2;

	[Token(Token = "0x4000B22")]
	[FieldOffset(Offset = "0x20")]
	private string author_;

	[Token(Token = "0x4000B23")]
	public const int ContentFieldNumber = 3;

	[Token(Token = "0x4000B24")]
	[FieldOffset(Offset = "0x28")]
	private string content_;

	[Token(Token = "0x17000722")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<PopupWarningEvent> Parser
	{
		[Token(Token = "0x600214E")]
		[Address(RVA = "0x97E7E0", Offset = "0x97DBE0", VA = "0x18097E7E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000723")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600214F")]
		[Address(RVA = "0x97E730", Offset = "0x97DB30", VA = "0x18097E730")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000724")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002150")]
		[Address(RVA = "0x97E9F0", Offset = "0x97DDF0", VA = "0x18097E9F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000725")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int LockDuration
	{
		[Token(Token = "0x6002154")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002155")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x17000726")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Author
	{
		[Token(Token = "0x6002156")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002157")]
		[Address(RVA = "0x97EAD0", Offset = "0x97DED0", VA = "0x18097EAD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000727")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Content
	{
		[Token(Token = "0x6002158")]
		[Address(RVA = "0x91A0B0", Offset = "0x9194B0", VA = "0x18091A0B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002159")]
		[Address(RVA = "0x97EB40", Offset = "0x97DF40", VA = "0x18097EB40")]
		set
		{
		}
	}

	[Token(Token = "0x6002151")]
	[Address(RVA = "0x97E6C0", Offset = "0x97DAC0", VA = "0x18097E6C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PopupWarningEvent()
	{
	}

	[Token(Token = "0x6002152")]
	[Address(RVA = "0x97E5E0", Offset = "0x97D9E0", VA = "0x18097E5E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopupWarningEvent(PopupWarningEvent other)
	{
	}

	[Token(Token = "0x6002153")]
	[Address(RVA = "0x97E0E0", Offset = "0x97D4E0", VA = "0x18097E0E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PopupWarningEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600215A")]
	[Address(RVA = "0x97E270", Offset = "0x97D670", VA = "0x18097E270", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600215B")]
	[Address(RVA = "0x97E1F0", Offset = "0x97D5F0", VA = "0x18097E1F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(PopupWarningEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x600215C")]
	[Address(RVA = "0x97E340", Offset = "0x97D740", VA = "0x18097E340", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600215D")]
	[Address(RVA = "0x97E480", Offset = "0x97D880", VA = "0x18097E480", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600215E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600215F")]
	[Address(RVA = "0x97E940", Offset = "0x97DD40", VA = "0x18097E940", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002160")]
	[Address(RVA = "0x97DFF0", Offset = "0x97D3F0", VA = "0x18097DFF0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002161")]
	[Address(RVA = "0x97E3F0", Offset = "0x97D7F0", VA = "0x18097E3F0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PopupWarningEvent other)
	{
	}

	[Token(Token = "0x6002162")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002163")]
	[Address(RVA = "0x97E830", Offset = "0x97DC30", VA = "0x18097E830", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
