using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Contact;

[Token(Token = "0x20007BA")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class BlockRequest : IMessage<BlockRequest>, IMessage, IEquatable<BlockRequest>, IDeepCloneable<BlockRequest>, IBufferMessage
{
	[Token(Token = "0x4001AD9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<BlockRequest> _parser;

	[Token(Token = "0x4001ADA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001ADB")]
	public const int PlayerSearchFieldNumber = 1;

	[Token(Token = "0x4001ADC")]
	[FieldOffset(Offset = "0x18")]
	private PlayerSearch playerSearch_;

	[Token(Token = "0x17001184")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<BlockRequest> Parser
	{
		[Token(Token = "0x600521E")]
		[Address(RVA = "0xAE7EC0", Offset = "0xAE72C0", VA = "0x180AE7EC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001185")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600521F")]
		[Address(RVA = "0xAE7E10", Offset = "0xAE7210", VA = "0x180AE7E10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001186")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005220")]
		[Address(RVA = "0xAE8010", Offset = "0xAE7410", VA = "0x180AE8010", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001187")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PlayerSearch PlayerSearch
	{
		[Token(Token = "0x6005224")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005225")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6005221")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BlockRequest()
	{
	}

	[Token(Token = "0x6005222")]
	[Address(RVA = "0xADD720", Offset = "0xADCB20", VA = "0x180ADD720")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public BlockRequest(BlockRequest other)
	{
	}

	[Token(Token = "0x6005223")]
	[Address(RVA = "0xAE7A90", Offset = "0xAE6E90", VA = "0x180AE7A90", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public BlockRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005226")]
	[Address(RVA = "0xAE7B30", Offset = "0xAE6F30", VA = "0x180AE7B30", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005227")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(BlockRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005228")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005229")]
	[Address(RVA = "0xAE7CB0", Offset = "0xAE70B0", VA = "0x180AE7CB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600522A")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600522B")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600522C")]
	[Address(RVA = "0xAE7A00", Offset = "0xAE6E00", VA = "0x180AE7A00", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600522D")]
	[Address(RVA = "0xAE7BE0", Offset = "0xAE6FE0", VA = "0x180AE7BE0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(BlockRequest other)
	{
	}

	[Token(Token = "0x600522E")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600522F")]
	[Address(RVA = "0xAE7F10", Offset = "0xAE7310", VA = "0x180AE7F10", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
