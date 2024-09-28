using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x2000427")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagFurnitureRequest : IMessage<HavenBagFurnitureRequest>, IMessage, IEquatable<HavenBagFurnitureRequest>, IDeepCloneable<HavenBagFurnitureRequest>, IBufferMessage
{
	[Token(Token = "0x4000E70")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagFurnitureRequest> _parser;

	[Token(Token = "0x4000E71")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000E72")]
	public const int FurnitureFieldNumber = 1;

	[Token(Token = "0x4000E73")]
	[FieldOffset(Offset = "0x8")]
	private static readonly FieldCodec<Element> _repeated_furniture_codec;

	[Token(Token = "0x4000E74")]
	[FieldOffset(Offset = "0x18")]
	private readonly RepeatedField<Element> furniture_;

	[Token(Token = "0x17000966")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HavenBagFurnitureRequest> Parser
	{
		[Token(Token = "0x6002BD7")]
		[Address(RVA = "0x9BC6E0", Offset = "0x9BBAE0", VA = "0x1809BC6E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000967")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002BD8")]
		[Address(RVA = "0x9BC630", Offset = "0x9BBA30", VA = "0x1809BC630")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000968")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002BD9")]
		[Address(RVA = "0x9BC8F0", Offset = "0x9BBCF0", VA = "0x1809BC8F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000969")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public RepeatedField<Element> Furniture
	{
		[Token(Token = "0x6002BDD")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002BDA")]
	[Address(RVA = "0x9BC520", Offset = "0x9BB920", VA = "0x1809BC520")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagFurnitureRequest()
	{
	}

	[Token(Token = "0x6002BDB")]
	[Address(RVA = "0x9BC5A0", Offset = "0x9BB9A0", VA = "0x1809BC5A0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagFurnitureRequest(HavenBagFurnitureRequest other)
	{
	}

	[Token(Token = "0x6002BDC")]
	[Address(RVA = "0x9BC070", Offset = "0x9BB470", VA = "0x1809BC070", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagFurnitureRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002BDE")]
	[Address(RVA = "0x9BC1C0", Offset = "0x9BB5C0", VA = "0x1809BC1C0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002BDF")]
	[Address(RVA = "0x9BC130", Offset = "0x9BB530", VA = "0x1809BC130", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagFurnitureRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002BE0")]
	[Address(RVA = "0x9364E0", Offset = "0x9358E0", VA = "0x1809364E0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002BE1")]
	[Address(RVA = "0x9BC320", Offset = "0x9BB720", VA = "0x1809BC320", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002BE2")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002BE3")]
	[Address(RVA = "0x9BC840", Offset = "0x9BBC40", VA = "0x1809BC840", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002BE4")]
	[Address(RVA = "0x9BBFD0", Offset = "0x9BB3D0", VA = "0x1809BBFD0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002BE5")]
	[Address(RVA = "0x9BC2A0", Offset = "0x9BB6A0", VA = "0x1809BC2A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagFurnitureRequest other)
	{
	}

	[Token(Token = "0x6002BE6")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002BE7")]
	[Address(RVA = "0x9BC730", Offset = "0x9BBB30", VA = "0x1809BC730", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
