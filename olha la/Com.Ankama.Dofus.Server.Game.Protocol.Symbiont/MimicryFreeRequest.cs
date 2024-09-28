using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Symbiont;

[Token(Token = "0x20000F0")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MimicryFreeRequest : IMessage<MimicryFreeRequest>, IMessage, IEquatable<MimicryFreeRequest>, IDeepCloneable<MimicryFreeRequest>, IBufferMessage
{
	[Token(Token = "0x400032D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MimicryFreeRequest> _parser;

	[Token(Token = "0x400032E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400032F")]
	public const int HostUidFieldNumber = 1;

	[Token(Token = "0x4000330")]
	[FieldOffset(Offset = "0x18")]
	private int hostUid_;

	[Token(Token = "0x170001F4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MimicryFreeRequest> Parser
	{
		[Token(Token = "0x600093F")]
		[Address(RVA = "0xA57FC0", Offset = "0xA573C0", VA = "0x180A57FC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001F5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000940")]
		[Address(RVA = "0xA57F10", Offset = "0xA57310", VA = "0x180A57F10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001F6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000941")]
		[Address(RVA = "0xA58010", Offset = "0xA57410", VA = "0x180A58010", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001F7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int HostUid
	{
		[Token(Token = "0x6000945")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000946")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6000942")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MimicryFreeRequest()
	{
	}

	[Token(Token = "0x6000943")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MimicryFreeRequest(MimicryFreeRequest other)
	{
	}

	[Token(Token = "0x6000944")]
	[Address(RVA = "0xA57CA0", Offset = "0xA570A0", VA = "0x180A57CA0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MimicryFreeRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000947")]
	[Address(RVA = "0xA57D20", Offset = "0xA57120", VA = "0x180A57D20", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000948")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MimicryFreeRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000949")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600094A")]
	[Address(RVA = "0xA57DB0", Offset = "0xA571B0", VA = "0x180A57DB0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600094B")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600094C")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600094D")]
	[Address(RVA = "0xA57C10", Offset = "0xA57010", VA = "0x180A57C10", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600094E")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(MimicryFreeRequest other)
	{
	}

	[Token(Token = "0x600094F")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000950")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
