using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x2000443")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagFurnitureEvent : IMessage<HavenBagFurnitureEvent>, IMessage, IEquatable<HavenBagFurnitureEvent>, IDeepCloneable<HavenBagFurnitureEvent>, IBufferMessage
{
	[Token(Token = "0x4000EB8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagFurnitureEvent> _parser;

	[Token(Token = "0x4000EB9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000EBA")]
	public const int FurnitureFieldNumber = 1;

	[Token(Token = "0x4000EBB")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Element> _repeated_furniture_codec;

	[Token(Token = "0x4000EBC")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Element> furniture_;

	[Token(Token = "0x17000997")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HavenBagFurnitureEvent> Parser
	{
		[Token(Token = "0x6002CDE")]
		[Address(RVA = "0x9BB8A0", Offset = "0x9BACA0", VA = "0x1809BB8A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000998")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002CDF")]
		[Address(RVA = "0x9BB7F0", Offset = "0x9BABF0", VA = "0x1809BB7F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000999")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002CE0")]
		[Address(RVA = "0x9BBAB0", Offset = "0x9BAEB0", VA = "0x1809BBAB0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700099A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Element> Furniture
	{
		[Token(Token = "0x6002CE4")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002CE1")]
	[Address(RVA = "0x9BB6E0", Offset = "0x9BAAE0", VA = "0x1809BB6E0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagFurnitureEvent()
	{
	}

	[Token(Token = "0x6002CE2")]
	[Address(RVA = "0x9BB760", Offset = "0x9BAB60", VA = "0x1809BB760")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagFurnitureEvent(HavenBagFurnitureEvent other)
	{
	}

	[Token(Token = "0x6002CE3")]
	[Address(RVA = "0x9BB230", Offset = "0x9BA630", VA = "0x1809BB230", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagFurnitureEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002CE5")]
	[Address(RVA = "0x9BB380", Offset = "0x9BA780", VA = "0x1809BB380", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002CE6")]
	[Address(RVA = "0x9BB2F0", Offset = "0x9BA6F0", VA = "0x1809BB2F0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagFurnitureEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002CE7")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002CE8")]
	[Address(RVA = "0x9BB4E0", Offset = "0x9BA8E0", VA = "0x1809BB4E0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002CE9")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002CEA")]
	[Address(RVA = "0x9BBA00", Offset = "0x9BAE00", VA = "0x1809BBA00", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002CEB")]
	[Address(RVA = "0x9BB190", Offset = "0x9BA590", VA = "0x1809BB190", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002CEC")]
	[Address(RVA = "0x9BB460", Offset = "0x9BA860", VA = "0x1809BB460", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagFurnitureEvent other)
	{
	}

	[Token(Token = "0x6002CED")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002CEE")]
	[Address(RVA = "0x9BB8F0", Offset = "0x9BACF0", VA = "0x1809BB8F0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
