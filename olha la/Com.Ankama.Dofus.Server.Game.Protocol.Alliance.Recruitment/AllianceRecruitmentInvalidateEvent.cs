using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C56")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceRecruitmentInvalidateEvent : IMessage<AllianceRecruitmentInvalidateEvent>, IMessage, IEquatable<AllianceRecruitmentInvalidateEvent>, IDeepCloneable<AllianceRecruitmentInvalidateEvent>, IBufferMessage
{
	[Token(Token = "0x4002DB2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceRecruitmentInvalidateEvent> _parser;

	[Token(Token = "0x4002DB3")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001C77")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceRecruitmentInvalidateEvent> Parser
	{
		[Token(Token = "0x60081C3")]
		[Address(RVA = "0xC7BF00", Offset = "0xC7B300", VA = "0x180C7BF00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C78")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60081C4")]
		[Address(RVA = "0xC7BE50", Offset = "0xC7B250", VA = "0x180C7BE50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C79")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60081C5")]
		[Address(RVA = "0xC7BF50", Offset = "0xC7B350", VA = "0x180C7BF50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60081C6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRecruitmentInvalidateEvent()
	{
	}

	[Token(Token = "0x60081C7")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRecruitmentInvalidateEvent(AllianceRecruitmentInvalidateEvent other)
	{
	}

	[Token(Token = "0x60081C8")]
	[Address(RVA = "0xC7BBF0", Offset = "0xC7AFF0", VA = "0x180C7BBF0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRecruitmentInvalidateEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60081C9")]
	[Address(RVA = "0xC7BC70", Offset = "0xC7B070", VA = "0x180C7BC70", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60081CA")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceRecruitmentInvalidateEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60081CB")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60081CC")]
	[Address(RVA = "0xC7BCF0", Offset = "0xC7B0F0", VA = "0x180C7BCF0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60081CD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60081CE")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60081CF")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60081D0")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceRecruitmentInvalidateEvent other)
	{
	}

	[Token(Token = "0x60081D1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60081D2")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
