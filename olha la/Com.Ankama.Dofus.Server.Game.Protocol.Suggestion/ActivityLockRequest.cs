using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Suggestion;

[Token(Token = "0x20000F9")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class ActivityLockRequest : IMessage<ActivityLockRequest>, IMessage, IEquatable<ActivityLockRequest>, IDeepCloneable<ActivityLockRequest>, IBufferMessage
{
	[Token(Token = "0x400034A")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<ActivityLockRequest> _parser;

	[Token(Token = "0x400034B")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x400034C")]
	public const int ActivityIdFieldNumber = 1;

	[Token(Token = "0x400034D")]
	[FieldOffset(Offset = "0x18")]
	private int activityId_;

	[Token(Token = "0x17000209")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<ActivityLockRequest> Parser
	{
		[Token(Token = "0x60009A1")]
		[Address(RVA = "0xA54230", Offset = "0xA53630", VA = "0x180A54230")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700020A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60009A2")]
		[Address(RVA = "0xA54180", Offset = "0xA53580", VA = "0x180A54180")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700020B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60009A3")]
		[Address(RVA = "0xA54280", Offset = "0xA53680", VA = "0x180A54280", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700020C")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int ActivityId
	{
		[Token(Token = "0x60009A7")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60009A8")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60009A4")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivityLockRequest()
	{
	}

	[Token(Token = "0x60009A5")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivityLockRequest(ActivityLockRequest other)
	{
	}

	[Token(Token = "0x60009A6")]
	[Address(RVA = "0xA53F10", Offset = "0xA53310", VA = "0x180A53F10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActivityLockRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60009A9")]
	[Address(RVA = "0xA53F90", Offset = "0xA53390", VA = "0x180A53F90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60009AA")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(ActivityLockRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60009AB")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60009AC")]
	[Address(RVA = "0xA54020", Offset = "0xA53420", VA = "0x180A54020", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60009AD")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60009AE")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60009AF")]
	[Address(RVA = "0xA53E80", Offset = "0xA53280", VA = "0x180A53E80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60009B0")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(ActivityLockRequest other)
	{
	}

	[Token(Token = "0x60009B1")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60009B2")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
