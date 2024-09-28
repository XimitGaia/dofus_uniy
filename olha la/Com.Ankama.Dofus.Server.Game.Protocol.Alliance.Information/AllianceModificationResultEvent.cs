using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CB3")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceModificationResultEvent : IMessage<AllianceModificationResultEvent>, IMessage, IEquatable<AllianceModificationResultEvent>, IDeepCloneable<AllianceModificationResultEvent>, IBufferMessage
{
	[Token(Token = "0x4002EC0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceModificationResultEvent> _parser;

	[Token(Token = "0x4002EC1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002EC2")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x4002EC3")]
	[FieldOffset(Offset = "0x18")]
	private SocialGroupOperationResult result_;

	[Token(Token = "0x17001D41")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceModificationResultEvent> Parser
	{
		[Token(Token = "0x60085C9")]
		[Address(RVA = "0xC98E30", Offset = "0xC98230", VA = "0x180C98E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D42")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60085CA")]
		[Address(RVA = "0xC98D80", Offset = "0xC98180", VA = "0x180C98D80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D43")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60085CB")]
		[Address(RVA = "0xC98E80", Offset = "0xC98280", VA = "0x180C98E80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D44")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialGroupOperationResult Result
	{
		[Token(Token = "0x60085CF")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(SocialGroupOperationResult);
		}
		[Token(Token = "0x60085D0")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60085CC")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceModificationResultEvent()
	{
	}

	[Token(Token = "0x60085CD")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceModificationResultEvent(AllianceModificationResultEvent other)
	{
	}

	[Token(Token = "0x60085CE")]
	[Address(RVA = "0xC98B10", Offset = "0xC97F10", VA = "0x180C98B10", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceModificationResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60085D1")]
	[Address(RVA = "0xC98B90", Offset = "0xC97F90", VA = "0x180C98B90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60085D2")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceModificationResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60085D3")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60085D4")]
	[Address(RVA = "0xC98C20", Offset = "0xC98020", VA = "0x180C98C20", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60085D5")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60085D6")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60085D7")]
	[Address(RVA = "0xC98A80", Offset = "0xC97E80", VA = "0x180C98A80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60085D8")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceModificationResultEvent other)
	{
	}

	[Token(Token = "0x60085D9")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60085DA")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
