using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x200030B")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountInformationRequest : IMessage<MountInformationRequest>, IMessage, IEquatable<MountInformationRequest>, IDeepCloneable<MountInformationRequest>, IBufferMessage
{
	[Token(Token = "0x4000AA4")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountInformationRequest> _parser;

	[Token(Token = "0x4000AA5")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000AA6")]
	public const int MountIdFieldNumber = 1;

	[Token(Token = "0x4000AA7")]
	[FieldOffset(Offset = "0x18")]
	private int mountId_;

	[Token(Token = "0x4000AA8")]
	public const int TimeFieldNumber = 2;

	[Token(Token = "0x4000AA9")]
	[FieldOffset(Offset = "0x20")]
	private long time_;

	[Token(Token = "0x170006CC")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<MountInformationRequest> Parser
	{
		[Token(Token = "0x6001F8B")]
		[Address(RVA = "0xD1E0F0", Offset = "0xD1D4F0", VA = "0x180D1E0F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006CD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001F8C")]
		[Address(RVA = "0xD1E040", Offset = "0xD1D440", VA = "0x180D1E040")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006CE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001F8D")]
		[Address(RVA = "0xD1E140", Offset = "0xD1D540", VA = "0x180D1E140", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006CF")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int MountId
	{
		[Token(Token = "0x6001F91")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001F92")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x170006D0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public long Time
	{
		[Token(Token = "0x6001F93")]
		[Address(RVA = "0x7D2770", Offset = "0x7D1B70", VA = "0x1807D2770")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6001F94")]
		[Address(RVA = "0x91A4B0", Offset = "0x9198B0", VA = "0x18091A4B0")]
		set
		{
		}
	}

	[Token(Token = "0x6001F8E")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountInformationRequest()
	{
	}

	[Token(Token = "0x6001F8F")]
	[Address(RVA = "0x950DA0", Offset = "0x9501A0", VA = "0x180950DA0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountInformationRequest(MountInformationRequest other)
	{
	}

	[Token(Token = "0x6001F90")]
	[Address(RVA = "0xD1DDB0", Offset = "0xD1D1B0", VA = "0x180D1DDB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountInformationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001F95")]
	[Address(RVA = "0xD1DE40", Offset = "0xD1D240", VA = "0x180D1DE40", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F96")]
	[Address(RVA = "0x950A70", Offset = "0x94FE70", VA = "0x180950A70", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(MountInformationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001F97")]
	[Address(RVA = "0x950B50", Offset = "0x94FF50", VA = "0x180950B50", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001F98")]
	[Address(RVA = "0xD1DEE0", Offset = "0xD1D2E0", VA = "0x180D1DEE0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001F99")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001F9A")]
	[Address(RVA = "0x950F80", Offset = "0x950380", VA = "0x180950F80", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001F9B")]
	[Address(RVA = "0xD1DCF0", Offset = "0xD1D0F0", VA = "0x180D1DCF0", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001F9C")]
	[Address(RVA = "0x950BE0", Offset = "0x94FFE0", VA = "0x180950BE0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MountInformationRequest other)
	{
	}

	[Token(Token = "0x6001F9D")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001F9E")]
	[Address(RVA = "0x950ED0", Offset = "0x9502D0", VA = "0x180950ED0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
