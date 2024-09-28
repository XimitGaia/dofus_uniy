using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000D1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AddTagObjectRequest : IMessage<AddTagObjectRequest>, IMessage, IEquatable<AddTagObjectRequest>, IDeepCloneable<AddTagObjectRequest>, IBufferMessage
{
	[Token(Token = "0x40002CD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AddTagObjectRequest> _parser;

	[Token(Token = "0x40002CE")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002CF")]
	public const int TagObjectUpdateContentFieldNumber = 1;

	[Token(Token = "0x40002D0")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<TagObjectUpdateContent> _repeated_tagObjectUpdateContent_codec;

	[Token(Token = "0x40002D1")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<TagObjectUpdateContent> tagObjectUpdateContent_;

	[Token(Token = "0x170001B5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AddTagObjectRequest> Parser
	{
		[Token(Token = "0x6000803")]
		[Address(RVA = "0xA55F80", Offset = "0xA55380", VA = "0x180A55F80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000804")]
		[Address(RVA = "0xA55ED0", Offset = "0xA552D0", VA = "0x180A55ED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000805")]
		[Address(RVA = "0xA56190", Offset = "0xA55590", VA = "0x180A56190", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<TagObjectUpdateContent> TagObjectUpdateContent
	{
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000806")]
	[Address(RVA = "0xA55E50", Offset = "0xA55250", VA = "0x180A55E50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddTagObjectRequest()
	{
	}

	[Token(Token = "0x6000807")]
	[Address(RVA = "0xA55DC0", Offset = "0xA551C0", VA = "0x180A55DC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AddTagObjectRequest(AddTagObjectRequest other)
	{
	}

	[Token(Token = "0x6000808")]
	[Address(RVA = "0xA55910", Offset = "0xA54D10", VA = "0x180A55910", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddTagObjectRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x600080A")]
	[Address(RVA = "0xA55A60", Offset = "0xA54E60", VA = "0x180A55A60", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600080B")]
	[Address(RVA = "0xA559D0", Offset = "0xA54DD0", VA = "0x180A559D0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AddTagObjectRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x600080C")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600080D")]
	[Address(RVA = "0xA55BC0", Offset = "0xA54FC0", VA = "0x180A55BC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600080E")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600080F")]
	[Address(RVA = "0xA560E0", Offset = "0xA554E0", VA = "0x180A560E0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000810")]
	[Address(RVA = "0xA55870", Offset = "0xA54C70", VA = "0x180A55870", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000811")]
	[Address(RVA = "0xA55B40", Offset = "0xA54F40", VA = "0x180A55B40", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AddTagObjectRequest other)
	{
	}

	[Token(Token = "0x6000812")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000813")]
	[Address(RVA = "0xA55FD0", Offset = "0xA553D0", VA = "0x180A55FD0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
