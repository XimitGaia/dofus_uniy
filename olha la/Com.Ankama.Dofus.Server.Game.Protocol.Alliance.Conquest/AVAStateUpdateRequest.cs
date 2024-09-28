using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Conquest;

[Token(Token = "0x2000CD3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AVAStateUpdateRequest : IMessage<AVAStateUpdateRequest>, IMessage, IEquatable<AVAStateUpdateRequest>, IDeepCloneable<AVAStateUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x4002F43")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AVAStateUpdateRequest> _parser;

	[Token(Token = "0x4002F44")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002F45")]
	public const int EnableFieldNumber = 1;

	[Token(Token = "0x4002F46")]
	[FieldOffset(Offset = "0x18")]
	private bool enable_;

	[Token(Token = "0x17001D8F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AVAStateUpdateRequest> Parser
	{
		[Token(Token = "0x6008722")]
		[Address(RVA = "0xCA0350", Offset = "0xC9F750", VA = "0x180CA0350")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D90")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008723")]
		[Address(RVA = "0xCA02A0", Offset = "0xC9F6A0", VA = "0x180CA02A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D91")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008724")]
		[Address(RVA = "0xCA03A0", Offset = "0xC9F7A0", VA = "0x180CA03A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D92")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Enable
	{
		[Token(Token = "0x6008728")]
		[Address(RVA = "0x87EAC0", Offset = "0x87DEC0", VA = "0x18087EAC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6008729")]
		[Address(RVA = "0x87EB00", Offset = "0x87DF00", VA = "0x18087EB00")]
		set
		{
		}
	}

	[Token(Token = "0x6008725")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AVAStateUpdateRequest()
	{
	}

	[Token(Token = "0x6008726")]
	[Address(RVA = "0x951480", Offset = "0x950880", VA = "0x180951480")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AVAStateUpdateRequest(AVAStateUpdateRequest other)
	{
	}

	[Token(Token = "0x6008727")]
	[Address(RVA = "0xC9FF90", Offset = "0xC9F390", VA = "0x180C9FF90", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AVAStateUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600872A")]
	[Address(RVA = "0xCA0010", Offset = "0xC9F410", VA = "0x180CA0010", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600872B")]
	[Address(RVA = "0x951170", Offset = "0x950570", VA = "0x180951170", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AVAStateUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600872C")]
	[Address(RVA = "0xCA00A0", Offset = "0xC9F4A0", VA = "0x180CA00A0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600872D")]
	[Address(RVA = "0xCA0140", Offset = "0xC9F540", VA = "0x180CA0140", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600872E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600872F")]
	[Address(RVA = "0x951670", Offset = "0x950A70", VA = "0x180951670", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008730")]
	[Address(RVA = "0x9510B0", Offset = "0x9504B0", VA = "0x1809510B0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6008731")]
	[Address(RVA = "0x9512D0", Offset = "0x9506D0", VA = "0x1809512D0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AVAStateUpdateRequest other)
	{
	}

	[Token(Token = "0x6008732")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6008733")]
	[Address(RVA = "0x9515D0", Offset = "0x9509D0", VA = "0x1809515D0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
