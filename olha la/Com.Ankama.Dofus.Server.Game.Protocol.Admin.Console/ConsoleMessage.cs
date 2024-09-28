using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Admin.Console;

[Token(Token = "0x2000D08")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ConsoleMessage : IMessage<ConsoleMessage>, IMessage, IEquatable<ConsoleMessage>, IDeepCloneable<ConsoleMessage>, IBufferMessage
{
	[Token(Token = "0x2000D09")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static class Types
	{
		[Token(Token = "0x2000D0A")]
		public enum Type
		{
			[Token(Token = "0x4002FE6")]
			[OriginalName("TEXT")]
			Text,
			[Token(Token = "0x4002FE7")]
			[OriginalName("INFO")]
			Info,
			[Token(Token = "0x4002FE8")]
			[OriginalName("ERROR")]
			Error
		}
	}

	[Token(Token = "0x4002FDF")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ConsoleMessage> _parser;

	[Token(Token = "0x4002FE0")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002FE1")]
	public const int ContentFieldNumber = 1;

	[Token(Token = "0x4002FE2")]
	[FieldOffset(Offset = "0x18")]
	private string content_;

	[Token(Token = "0x4002FE3")]
	public const int TypeFieldNumber = 2;

	[Token(Token = "0x4002FE4")]
	[FieldOffset(Offset = "0x20")]
	private Types.Type type_;

	[Token(Token = "0x17001DFD")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<ConsoleMessage> Parser
	{
		[Token(Token = "0x6008949")]
		[Address(RVA = "0xCB1820", Offset = "0xCB0C20", VA = "0x180CB1820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DFE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600894A")]
		[Address(RVA = "0xCB1770", Offset = "0xCB0B70", VA = "0x180CB1770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001DFF")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600894B")]
		[Address(RVA = "0xCB1940", Offset = "0xCB0D40", VA = "0x180CB1940", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001E00")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string Content
	{
		[Token(Token = "0x600894F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008950")]
		[Address(RVA = "0xCB1A20", Offset = "0xCB0E20", VA = "0x180CB1A20")]
		set
		{
		}
	}

	[Token(Token = "0x17001E01")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.Type Type
	{
		[Token(Token = "0x6008951")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(Types.Type);
		}
		[Token(Token = "0x6008952")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x600894C")]
	[Address(RVA = "0xCB1670", Offset = "0xCB0A70", VA = "0x180CB1670")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ConsoleMessage()
	{
	}

	[Token(Token = "0x600894D")]
	[Address(RVA = "0xCB16C0", Offset = "0xCB0AC0", VA = "0x180CB16C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ConsoleMessage(ConsoleMessage other)
	{
	}

	[Token(Token = "0x600894E")]
	[Address(RVA = "0xCB1320", Offset = "0xCB0720", VA = "0x180CB1320", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ConsoleMessage Clone()
	{
		return null;
	}

	[Token(Token = "0x6008953")]
	[Address(RVA = "0xCB13F0", Offset = "0xCB07F0", VA = "0x180CB13F0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008954")]
	[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ConsoleMessage other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008955")]
	[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008956")]
	[Address(RVA = "0xCB1510", Offset = "0xCB0910", VA = "0x180CB1510", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008957")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008958")]
	[Address(RVA = "0x958970", Offset = "0x957D70", VA = "0x180958970", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008959")]
	[Address(RVA = "0xCB1260", Offset = "0xCB0660", VA = "0x180CB1260", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600895A")]
	[Address(RVA = "0xCB14A0", Offset = "0xCB08A0", VA = "0x180CB14A0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(ConsoleMessage other)
	{
	}

	[Token(Token = "0x600895B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600895C")]
	[Address(RVA = "0xCB1870", Offset = "0xCB0C70", VA = "0x180CB1870", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
