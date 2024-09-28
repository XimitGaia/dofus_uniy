using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000D5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class RemoveTagObjectRequest : IMessage<RemoveTagObjectRequest>, IMessage, IEquatable<RemoveTagObjectRequest>, IDeepCloneable<RemoveTagObjectRequest>, IBufferMessage
{
	[Token(Token = "0x40002D9")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<RemoveTagObjectRequest> _parser;

	[Token(Token = "0x40002DA")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002DB")]
	public const int TagObjectUpdateContentFieldNumber = 1;

	[Token(Token = "0x40002DC")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<TagObjectUpdateContent> _repeated_tagObjectUpdateContent_codec;

	[Token(Token = "0x40002DD")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<TagObjectUpdateContent> tagObjectUpdateContent_;

	[Token(Token = "0x170001BD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RemoveTagObjectRequest> Parser
	{
		[Token(Token = "0x600082D")]
		[Address(RVA = "0xA596F0", Offset = "0xA58AF0", VA = "0x180A596F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001BE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600082E")]
		[Address(RVA = "0xA59640", Offset = "0xA58A40", VA = "0x180A59640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001BF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600082F")]
		[Address(RVA = "0xA59900", Offset = "0xA58D00", VA = "0x180A59900", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<TagObjectUpdateContent> TagObjectUpdateContent
	{
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000830")]
	[Address(RVA = "0xA59530", Offset = "0xA58930", VA = "0x180A59530")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RemoveTagObjectRequest()
	{
	}

	[Token(Token = "0x6000831")]
	[Address(RVA = "0xA595B0", Offset = "0xA589B0", VA = "0x180A595B0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveTagObjectRequest(RemoveTagObjectRequest other)
	{
	}

	[Token(Token = "0x6000832")]
	[Address(RVA = "0xA59080", Offset = "0xA58480", VA = "0x180A59080", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveTagObjectRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6000834")]
	[Address(RVA = "0xA59140", Offset = "0xA58540", VA = "0x180A59140", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000835")]
	[Address(RVA = "0xA59220", Offset = "0xA58620", VA = "0x180A59220", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(RemoveTagObjectRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000836")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000837")]
	[Address(RVA = "0xA59330", Offset = "0xA58730", VA = "0x180A59330", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000838")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000839")]
	[Address(RVA = "0xA59850", Offset = "0xA58C50", VA = "0x180A59850", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600083A")]
	[Address(RVA = "0xA58FE0", Offset = "0xA583E0", VA = "0x180A58FE0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600083B")]
	[Address(RVA = "0xA592B0", Offset = "0xA586B0", VA = "0x180A592B0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RemoveTagObjectRequest other)
	{
	}

	[Token(Token = "0x600083C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600083D")]
	[Address(RVA = "0xA59740", Offset = "0xA58B40", VA = "0x180A59740", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
