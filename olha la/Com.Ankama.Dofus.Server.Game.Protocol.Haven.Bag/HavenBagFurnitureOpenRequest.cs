using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x2000425")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagFurnitureOpenRequest : IMessage<HavenBagFurnitureOpenRequest>, IMessage, IEquatable<HavenBagFurnitureOpenRequest>, IDeepCloneable<HavenBagFurnitureOpenRequest>, IBufferMessage
{
	[Token(Token = "0x4000E6D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagFurnitureOpenRequest> _parser;

	[Token(Token = "0x4000E6E")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17000963")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HavenBagFurnitureOpenRequest> Parser
	{
		[Token(Token = "0x6002BC3")]
		[Address(RVA = "0x9BBEA0", Offset = "0x9BB2A0", VA = "0x1809BBEA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000964")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002BC4")]
		[Address(RVA = "0x9BBDF0", Offset = "0x9BB1F0", VA = "0x1809BBDF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000965")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002BC5")]
		[Address(RVA = "0x9BBEF0", Offset = "0x9BB2F0", VA = "0x1809BBEF0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002BC6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagFurnitureOpenRequest()
	{
	}

	[Token(Token = "0x6002BC7")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagFurnitureOpenRequest(HavenBagFurnitureOpenRequest other)
	{
	}

	[Token(Token = "0x6002BC8")]
	[Address(RVA = "0x9BBB90", Offset = "0x9BAF90", VA = "0x1809BBB90", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public HavenBagFurnitureOpenRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002BC9")]
	[Address(RVA = "0x9BBC10", Offset = "0x9BB010", VA = "0x1809BBC10", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002BCA")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagFurnitureOpenRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002BCB")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002BCC")]
	[Address(RVA = "0x9BBC90", Offset = "0x9BB090", VA = "0x1809BBC90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002BCD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002BCE")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002BCF")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002BD0")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagFurnitureOpenRequest other)
	{
	}

	[Token(Token = "0x6002BD1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002BD2")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
