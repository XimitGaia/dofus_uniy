using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Recruitment;

[Token(Token = "0x2000C4E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceRecruitmentInformationRequest : IMessage<AllianceRecruitmentInformationRequest>, IMessage, IEquatable<AllianceRecruitmentInformationRequest>, IDeepCloneable<AllianceRecruitmentInformationRequest>, IBufferMessage
{
	[Token(Token = "0x4002DA0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceRecruitmentInformationRequest> _parser;

	[Token(Token = "0x4002DA1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x17001C68")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceRecruitmentInformationRequest> Parser
	{
		[Token(Token = "0x600816D")]
		[Address(RVA = "0xC7BAC0", Offset = "0xC7AEC0", VA = "0x180C7BAC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C69")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600816E")]
		[Address(RVA = "0xC7BA10", Offset = "0xC7AE10", VA = "0x180C7BA10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C6A")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600816F")]
		[Address(RVA = "0xC7BB10", Offset = "0xC7AF10", VA = "0x180C7BB10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6008170")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public AllianceRecruitmentInformationRequest()
	{
	}

	[Token(Token = "0x6008171")]
	[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRecruitmentInformationRequest(AllianceRecruitmentInformationRequest other)
	{
	}

	[Token(Token = "0x6008172")]
	[Address(RVA = "0xC7B7B0", Offset = "0xC7ABB0", VA = "0x180C7B7B0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceRecruitmentInformationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008173")]
	[Address(RVA = "0xC7B830", Offset = "0xC7AC30", VA = "0x180C7B830", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008174")]
	[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(AllianceRecruitmentInformationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008175")]
	[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008176")]
	[Address(RVA = "0xC7B8B0", Offset = "0xC7ACB0", VA = "0x180C7B8B0", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008177")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6008178")]
	[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6008179")]
	[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600817A")]
	[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceRecruitmentInformationRequest other)
	{
	}

	[Token(Token = "0x600817B")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600817C")]
	[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
