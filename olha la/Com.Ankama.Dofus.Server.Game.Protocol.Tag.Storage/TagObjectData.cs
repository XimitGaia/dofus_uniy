using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Tag.Storage;

[Token(Token = "0x20000E5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class TagObjectData : IMessage<TagObjectData>, IMessage, IEquatable<TagObjectData>, IDeepCloneable<TagObjectData>, IBufferMessage
{
	[Token(Token = "0x400030C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<TagObjectData> _parser;

	[Token(Token = "0x400030D")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400030E")]
	public const int TagObjectUuidsFieldNumber = 1;

	[Token(Token = "0x400030F")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<int> _repeated_tagObjectUuids_codec;

	[Token(Token = "0x4000310")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<int> tagObjectUuids_;

	[Token(Token = "0x170001E1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<TagObjectData> Parser
	{
		[Token(Token = "0x60008E2")]
		[Address(RVA = "0xA5EF10", Offset = "0xA5E310", VA = "0x180A5EF10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60008E3")]
		[Address(RVA = "0xA5EE60", Offset = "0xA5E260", VA = "0x180A5EE60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0xA5F130", Offset = "0xA5E530", VA = "0x180A5F130", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001E4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<int> TagObjectUuids
	{
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60008E5")]
	[Address(RVA = "0xA5ED50", Offset = "0xA5E150", VA = "0x180A5ED50")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TagObjectData()
	{
	}

	[Token(Token = "0x60008E6")]
	[Address(RVA = "0xA5EDD0", Offset = "0xA5E1D0", VA = "0x180A5EDD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public TagObjectData(TagObjectData other)
	{
	}

	[Token(Token = "0x60008E7")]
	[Address(RVA = "0xA5E910", Offset = "0xA5DD10", VA = "0x180A5E910", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public TagObjectData Clone()
	{
		return null;
	}

	[Token(Token = "0x60008E9")]
	[Address(RVA = "0xA5EA60", Offset = "0xA5DE60", VA = "0x180A5EA60", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60008EA")]
	[Address(RVA = "0xA5E9D0", Offset = "0xA5DDD0", VA = "0x180A5E9D0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(TagObjectData other)
	{
		return default(bool);
	}

	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60008EC")]
	[Address(RVA = "0xA5EBC0", Offset = "0xA5DFC0", VA = "0x180A5EBC0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60008EE")]
	[Address(RVA = "0xA5F080", Offset = "0xA5E480", VA = "0x180A5F080", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60008EF")]
	[Address(RVA = "0xA5E870", Offset = "0xA5DC70", VA = "0x180A5E870", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60008F0")]
	[Address(RVA = "0xA5EB40", Offset = "0xA5DF40", VA = "0x180A5EB40", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(TagObjectData other)
	{
	}

	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60008F2")]
	[Address(RVA = "0xA5EF60", Offset = "0xA5E360", VA = "0x180A5EF60", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
