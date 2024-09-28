using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Alliance.Information;

[Token(Token = "0x2000CA5")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class AllianceNameAndTagModificationValidRequest : IMessage<AllianceNameAndTagModificationValidRequest>, IMessage, IEquatable<AllianceNameAndTagModificationValidRequest>, IDeepCloneable<AllianceNameAndTagModificationValidRequest>, IBufferMessage
{
	[Token(Token = "0x4002E99")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<AllianceNameAndTagModificationValidRequest> _parser;

	[Token(Token = "0x4002E9A")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4002E9B")]
	public const int AllianceNameFieldNumber = 1;

	[Token(Token = "0x4002E9C")]
	[FieldOffset(Offset = "0x18")]
	private string allianceName_;

	[Token(Token = "0x4002E9D")]
	public const int AllianceTagFieldNumber = 2;

	[Token(Token = "0x4002E9E")]
	[FieldOffset(Offset = "0x20")]
	private string allianceTag_;

	[Token(Token = "0x17001D23")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<AllianceNameAndTagModificationValidRequest> Parser
	{
		[Token(Token = "0x600852B")]
		[Address(RVA = "0xC9BCD0", Offset = "0xC9B0D0", VA = "0x180C9BCD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D24")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600852C")]
		[Address(RVA = "0xC9BC20", Offset = "0xC9B020", VA = "0x180C9BC20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D25")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600852D")]
		[Address(RVA = "0xC9BE10", Offset = "0xC9B210", VA = "0x180C9BE10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D26")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string AllianceName
	{
		[Token(Token = "0x6008531")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008532")]
		[Address(RVA = "0xC9BEF0", Offset = "0xC9B2F0", VA = "0x180C9BEF0")]
		set
		{
		}
	}

	[Token(Token = "0x17001D27")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public string AllianceTag
	{
		[Token(Token = "0x6008533")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return null;
		}
		[Token(Token = "0x6008534")]
		[Address(RVA = "0xC9BF60", Offset = "0xC9B360", VA = "0x180C9BF60")]
		set
		{
		}
	}

	[Token(Token = "0x600852E")]
	[Address(RVA = "0xC9BBB0", Offset = "0xC9AFB0", VA = "0x180C9BBB0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceNameAndTagModificationValidRequest()
	{
	}

	[Token(Token = "0x600852F")]
	[Address(RVA = "0xC9BAD0", Offset = "0xC9AED0", VA = "0x180C9BAD0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceNameAndTagModificationValidRequest(AllianceNameAndTagModificationValidRequest other)
	{
	}

	[Token(Token = "0x6008530")]
	[Address(RVA = "0xC9B730", Offset = "0xC9AB30", VA = "0x180C9B730", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public AllianceNameAndTagModificationValidRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6008535")]
	[Address(RVA = "0xC9B830", Offset = "0xC9AC30", VA = "0x180C9B830", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008536")]
	[Address(RVA = "0x931D60", Offset = "0x931160", VA = "0x180931D60", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(AllianceNameAndTagModificationValidRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6008537")]
	[Address(RVA = "0x931DE0", Offset = "0x9311E0", VA = "0x180931DE0", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6008538")]
	[Address(RVA = "0xC9B970", Offset = "0xC9AD70", VA = "0x180C9B970", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6008539")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x600853A")]
	[Address(RVA = "0x932390", Offset = "0x931790", VA = "0x180932390", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600853B")]
	[Address(RVA = "0xC9B670", Offset = "0xC9AA70", VA = "0x180C9B670", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600853C")]
	[Address(RVA = "0xC9B8F0", Offset = "0xC9ACF0", VA = "0x180C9B8F0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(AllianceNameAndTagModificationValidRequest other)
	{
	}

	[Token(Token = "0x600853D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600853E")]
	[Address(RVA = "0xC9BD20", Offset = "0xC9B120", VA = "0x180C9BD20", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
