using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Haven.Bag;

[Token(Token = "0x2000429")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class HavenBagFurnitureCloseRequest : IMessage<HavenBagFurnitureCloseRequest>, IMessage, IEquatable<HavenBagFurnitureCloseRequest>, IDeepCloneable<HavenBagFurnitureCloseRequest>, IBufferMessage
{
	[Token(Token = "0x4000E76")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<HavenBagFurnitureCloseRequest> _parser;

	[Token(Token = "0x4000E77")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x1700096A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<HavenBagFurnitureCloseRequest> Parser
	{
		[Token(Token = "0x6002BEC")]
		[Address(RVA = "0x9BB060", Offset = "0x9BA460", VA = "0x1809BB060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700096B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6002BED")]
		[Address(RVA = "0x9BAFB0", Offset = "0x9BA3B0", VA = "0x1809BAFB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700096C")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6002BEE")]
		[Address(RVA = "0x9BB0B0", Offset = "0x9BA4B0", VA = "0x1809BB0B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002BEF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagFurnitureCloseRequest()
	{
	}

	[Token(Token = "0x6002BF0")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagFurnitureCloseRequest(HavenBagFurnitureCloseRequest other)
	{
	}

	[Token(Token = "0x6002BF1")]
	[Address(RVA = "0x9BAD50", Offset = "0x9BA150", VA = "0x1809BAD50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public HavenBagFurnitureCloseRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002BF2")]
	[Address(RVA = "0x9BADD0", Offset = "0x9BA1D0", VA = "0x1809BADD0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002BF3")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(HavenBagFurnitureCloseRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002BF4")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002BF5")]
	[Address(RVA = "0x9BAE50", Offset = "0x9BA250", VA = "0x1809BAE50", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002BF6")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002BF7")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002BF8")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002BF9")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(HavenBagFurnitureCloseRequest other)
	{
	}

	[Token(Token = "0x6002BFA")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6002BFB")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
