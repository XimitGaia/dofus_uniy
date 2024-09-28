using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000D7")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class RemoveTagObjectResponse : IMessage<RemoveTagObjectResponse>, IMessage, IEquatable<RemoveTagObjectResponse>, IDeepCloneable<RemoveTagObjectResponse>, IBufferMessage
{
	[Token(Token = "0x40002DF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<RemoveTagObjectResponse> _parser;

	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40002E1")]
	public const int ObjectIdsFieldNumber = 1;

	[Token(Token = "0x40002E2")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_objectIds_codec;

	[Token(Token = "0x40002E3")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> objectIds_;

	[Token(Token = "0x170001C1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<RemoveTagObjectResponse> Parser
	{
		[Token(Token = "0x6000842")]
		[Address(RVA = "0xA5A080", Offset = "0xA59480", VA = "0x180A5A080")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000843")]
		[Address(RVA = "0xA59FD0", Offset = "0xA593D0", VA = "0x180A59FD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000844")]
		[Address(RVA = "0xA5A2A0", Offset = "0xA596A0", VA = "0x180A5A2A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001C4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RepeatedField<int> ObjectIds
	{
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000845")]
	[Address(RVA = "0xA59EC0", Offset = "0xA592C0", VA = "0x180A59EC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveTagObjectResponse()
	{
	}

	[Token(Token = "0x6000846")]
	[Address(RVA = "0xA59F40", Offset = "0xA59340", VA = "0x180A59F40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public RemoveTagObjectResponse(RemoveTagObjectResponse other)
	{
	}

	[Token(Token = "0x6000847")]
	[Address(RVA = "0xA59A80", Offset = "0xA58E80", VA = "0x180A59A80", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RemoveTagObjectResponse Clone()
	{
		return null;
	}

	[Token(Token = "0x6000849")]
	[Address(RVA = "0xA59BD0", Offset = "0xA58FD0", VA = "0x180A59BD0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x600084A")]
	[Address(RVA = "0xA59B40", Offset = "0xA58F40", VA = "0x180A59B40", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(RemoveTagObjectResponse other)
	{
		return default(bool);
	}

	[Token(Token = "0x600084B")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600084C")]
	[Address(RVA = "0xA59D30", Offset = "0xA59130", VA = "0x180A59D30", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600084D")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600084E")]
	[Address(RVA = "0xA5A1F0", Offset = "0xA595F0", VA = "0x180A5A1F0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600084F")]
	[Address(RVA = "0xA599E0", Offset = "0xA58DE0", VA = "0x180A599E0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000850")]
	[Address(RVA = "0xA59CB0", Offset = "0xA590B0", VA = "0x180A59CB0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(RemoveTagObjectResponse other)
	{
	}

	[Token(Token = "0x6000851")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000852")]
	[Address(RVA = "0xA5A0D0", Offset = "0xA594D0", VA = "0x180A5A0D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
