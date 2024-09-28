using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C52")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceRecruitmentInformationEvent : IMessage<AllianceRecruitmentInformationEvent>, IMessage, IEquatable<AllianceRecruitmentInformationEvent>, IDeepCloneable<AllianceRecruitmentInformationEvent>, IBufferMessage
{
	[Token(Token = "0x4002DA8")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceRecruitmentInformationEvent> _parser;

	[Token(Token = "0x4002DA9")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002DAA")]
	public const int InformationFieldNumber = 1;

	[Token(Token = "0x4002DAB")]
	[FieldOffset(Offset = "0x18")]
	private AllianceRecruitmentInformation information_;

	[Token(Token = "0x17001C6F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<AllianceRecruitmentInformationEvent> Parser
	{
		[Token(Token = "0x6008197")]
		[Address(RVA = "0xC7B580", Offset = "0xC7A980", VA = "0x180C7B580")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C70")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6008198")]
		[Address(RVA = "0xC7B4D0", Offset = "0xC7A8D0", VA = "0x180C7B4D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C71")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6008199")]
		[Address(RVA = "0xC7B6D0", Offset = "0xC7AAD0", VA = "0x180C7B6D0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C72")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRecruitmentInformation Information
	{
		[Token(Token = "0x600819D")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x600819E")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x600819A")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRecruitmentInformationEvent()
	{
	}

	[Token(Token = "0x600819B")]
	[Address(RVA = "0xC7B460", Offset = "0xC7A860", VA = "0x180C7B460")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRecruitmentInformationEvent(AllianceRecruitmentInformationEvent other)
	{
	}

	[Token(Token = "0x600819C")]
	[Address(RVA = "0xC7B0E0", Offset = "0xC7A4E0", VA = "0x180C7B0E0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRecruitmentInformationEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x600819F")]
	[Address(RVA = "0xC7B180", Offset = "0xC7A580", VA = "0x180C7B180", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60081A0")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceRecruitmentInformationEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x60081A1")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60081A2")]
	[Address(RVA = "0xC7B300", Offset = "0xC7A700", VA = "0x180C7B300", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60081A3")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60081A4")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60081A5")]
	[Address(RVA = "0xC7B050", Offset = "0xC7A450", VA = "0x180C7B050", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60081A6")]
	[Address(RVA = "0xC7B230", Offset = "0xC7A630", VA = "0x180C7B230", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceRecruitmentInformationEvent other)
	{
	}

	[Token(Token = "0x60081A7")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60081A8")]
	[Address(RVA = "0xC7B5D0", Offset = "0xC7A9D0", VA = "0x180C7B5D0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
