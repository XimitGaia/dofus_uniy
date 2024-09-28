using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CB1")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceCreationResultEvent : IMessage<AllianceCreationResultEvent>, IMessage, IEquatable<AllianceCreationResultEvent>, IDeepCloneable<AllianceCreationResultEvent>, IBufferMessage
{
	[Token(Token = "0x4002EBB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceCreationResultEvent> _parser;

	[Token(Token = "0x4002EBC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002EBD")]
	public const int ResultFieldNumber = 1;

	[Token(Token = "0x4002EBE")]
	[FieldOffset(Offset = "0x18")]
	private SocialGroupOperationResult result_;

	[Token(Token = "0x17001D3D")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceCreationResultEvent> Parser
	{
		[Token(Token = "0x60085B3")]
		[Address(RVA = "0xC8BE30", Offset = "0xC8B230", VA = "0x180C8BE30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D3E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60085B4")]
		[Address(RVA = "0xC8BD80", Offset = "0xC8B180", VA = "0x180C8BD80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D3F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60085B5")]
		[Address(RVA = "0xC8BE80", Offset = "0xC8B280", VA = "0x180C8BE80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D40")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public SocialGroupOperationResult Result
	{
		[Token(Token = "0x60085B9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(SocialGroupOperationResult);
		}
		[Token(Token = "0x60085BA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x60085B6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceCreationResultEvent()
	{
	}

	[Token(Token = "0x60085B7")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceCreationResultEvent(AllianceCreationResultEvent other)
	{
	}

	[Token(Token = "0x60085B8")]
	[Address(RVA = "0xC8BB10", Offset = "0xC8AF10", VA = "0x180C8BB10", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceCreationResultEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x60085BB")]
	[Address(RVA = "0xC8BB90", Offset = "0xC8AF90", VA = "0x180C8BB90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60085BC")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceCreationResultEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60085BD")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60085BE")]
	[Address(RVA = "0xC8BC20", Offset = "0xC8B020", VA = "0x180C8BC20", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60085BF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60085C0")]
	[Address(RVA = "0x934790", Offset = "0x933B90", VA = "0x180934790", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60085C1")]
	[Address(RVA = "0xC8BA80", Offset = "0xC8AE80", VA = "0x180C8BA80", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60085C2")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(AllianceCreationResultEvent other)
	{
	}

	[Token(Token = "0x60085C3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60085C4")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
