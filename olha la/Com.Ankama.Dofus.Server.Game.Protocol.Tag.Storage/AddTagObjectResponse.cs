using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000D3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AddTagObjectResponse : IMessage<AddTagObjectResponse>, IMessage, IEquatable<AddTagObjectResponse>, IDeepCloneable<AddTagObjectResponse>, IBufferMessage
{
	[Token(Token = "0x40002D3")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AddTagObjectResponse> _parser;

	[Token(Token = "0x40002D4")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002D5")]
	public const int ObjectIdsFieldNumber = 1;

	[Token(Token = "0x40002D6")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_objectIds_codec;

	[Token(Token = "0x40002D7")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> objectIds_;

	[Token(Token = "0x170001B9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AddTagObjectResponse> Parser
	{
		[Token(Token = "0x6000818")]
		[Address(RVA = "0xA56910", Offset = "0xA55D10", VA = "0x180A56910")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001BA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000819")]
		[Address(RVA = "0xA56860", Offset = "0xA55C60", VA = "0x180A56860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001BB")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600081A")]
		[Address(RVA = "0xA56B30", Offset = "0xA55F30", VA = "0x180A56B30", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001BC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ObjectIds
	{
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600081B")]
	[Address(RVA = "0xA56750", Offset = "0xA55B50", VA = "0x180A56750")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AddTagObjectResponse()
	{
	}

	[Token(Token = "0x600081C")]
	[Address(RVA = "0xA567D0", Offset = "0xA55BD0", VA = "0x180A567D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AddTagObjectResponse(AddTagObjectResponse other)
	{
	}

	[Token(Token = "0x600081D")]
	[Address(RVA = "0xA56310", Offset = "0xA55710", VA = "0x180A56310", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AddTagObjectResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x600081F")]
	[Address(RVA = "0xA563D0", Offset = "0xA557D0", VA = "0x180A563D0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000820")]
	[Address(RVA = "0xA564B0", Offset = "0xA558B0", VA = "0x180A564B0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AddTagObjectResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000821")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000822")]
	[Address(RVA = "0xA565C0", Offset = "0xA559C0", VA = "0x180A565C0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000823")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000824")]
	[Address(RVA = "0xA56A80", Offset = "0xA55E80", VA = "0x180A56A80", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000825")]
	[Address(RVA = "0xA56270", Offset = "0xA55670", VA = "0x180A56270", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000826")]
	[Address(RVA = "0xA56540", Offset = "0xA55940", VA = "0x180A56540", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AddTagObjectResponse other)
	{
	}

	[Token(Token = "0x6000827")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000828")]
	[Address(RVA = "0xA56960", Offset = "0xA55D60", VA = "0x180A56960", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
