using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Security;

[Token(Token = "0x200015C")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class FileCheckEvent : IMessage<FileCheckEvent>, IMessage, IEquatable<FileCheckEvent>, IDeepCloneable<FileCheckEvent>, IBufferMessage
{
	[Token(Token = "0x40004A0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<FileCheckEvent> _parser;

	[Token(Token = "0x40004A1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x40004A2")]
	public const int FileNameFieldNumber = 1;

	[Token(Token = "0x40004A3")]
	[FieldOffset(Offset = "0x18")]
	private string fileName_;

	[Token(Token = "0x40004A4")]
	public const int CheckTypeFieldNumber = 2;

	[Token(Token = "0x40004A5")]
	[FieldOffset(Offset = "0x20")]
	private CheckType checkType_;

	[Token(Token = "0x170002E2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<FileCheckEvent> Parser
	{
		[Token(Token = "0x6000D79")]
		[Address(RVA = "0xC451D0", Offset = "0xC445D0", VA = "0x180C451D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6000D7A")]
		[Address(RVA = "0xC45120", Offset = "0xC44520", VA = "0x180C45120")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6000D7B")]
		[Address(RVA = "0xC452F0", Offset = "0xC446F0", VA = "0x180C452F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002E5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string FileName
	{
		[Token(Token = "0x6000D7F")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000D80")]
		[Address(RVA = "0xC453D0", Offset = "0xC447D0", VA = "0x180C453D0")]
		set
		{
		}
	}

	[Token(Token = "0x170002E6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CheckType CheckType
	{
		[Token(Token = "0x6000D81")]
		[Address(RVA = "0x7F4130", Offset = "0x7F3530", VA = "0x1807F4130")]
		get
		{
			return default(CheckType);
		}
		[Token(Token = "0x6000D82")]
		[Address(RVA = "0x7F4140", Offset = "0x7F3540", VA = "0x1807F4140")]
		set
		{
		}
	}

	[Token(Token = "0x6000D7C")]
	[Address(RVA = "0xC450D0", Offset = "0xC444D0", VA = "0x180C450D0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FileCheckEvent()
	{
	}

	[Token(Token = "0x6000D7D")]
	[Address(RVA = "0xC45020", Offset = "0xC44420", VA = "0x180C45020")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public FileCheckEvent(FileCheckEvent other)
	{
	}

	[Token(Token = "0x6000D7E")]
	[Address(RVA = "0xC44CD0", Offset = "0xC440D0", VA = "0x180C44CD0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public FileCheckEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6000D83")]
	[Address(RVA = "0xC44DA0", Offset = "0xC441A0", VA = "0x180C44DA0", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D84")]
	[Address(RVA = "0x955090", Offset = "0x954490", VA = "0x180955090", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(FileCheckEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D85")]
	[Address(RVA = "0x955100", Offset = "0x954500", VA = "0x180955100", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000D86")]
	[Address(RVA = "0xC44EC0", Offset = "0xC442C0", VA = "0x180C44EC0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000D87")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x958970", Offset = "0x957D70", VA = "0x180958970", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6000D89")]
	[Address(RVA = "0xC44C10", Offset = "0xC44010", VA = "0x180C44C10", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0xC44E50", Offset = "0xC44250", VA = "0x180C44E50", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(FileCheckEvent other)
	{
	}

	[Token(Token = "0x6000D8B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6000D8C")]
	[Address(RVA = "0xC45220", Offset = "0xC44620", VA = "0x180C45220", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
