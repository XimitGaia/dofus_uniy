using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Mount;

[Token(Token = "0x200030D")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class MountInformationInPaddockRequest : IMessage<MountInformationInPaddockRequest>, IMessage, IEquatable<MountInformationInPaddockRequest>, IDeepCloneable<MountInformationInPaddockRequest>, IBufferMessage
{
	[Token(Token = "0x4000AAB")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<MountInformationInPaddockRequest> _parser;

	[Token(Token = "0x4000AAC")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000AAD")]
	public const int MountIdFieldNumber = 1;

	[Token(Token = "0x4000AAE")]
	[FieldOffset(Offset = "0x18")]
	private int mountId_;

	[Token(Token = "0x170006D1")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<MountInformationInPaddockRequest> Parser
	{
		[Token(Token = "0x6001FA3")]
		[Address(RVA = "0xD1DBC0", Offset = "0xD1CFC0", VA = "0x180D1DBC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6001FA4")]
		[Address(RVA = "0xD1DB10", Offset = "0xD1CF10", VA = "0x180D1DB10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6001FA5")]
		[Address(RVA = "0xD1DC10", Offset = "0xD1D010", VA = "0x180D1DC10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int MountId
	{
		[Token(Token = "0x6001FA9")]
		[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001FAA")]
		[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
		set
		{
		}
	}

	[Token(Token = "0x6001FA6")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountInformationInPaddockRequest()
	{
	}

	[Token(Token = "0x6001FA7")]
	[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public MountInformationInPaddockRequest(MountInformationInPaddockRequest other)
	{
	}

	[Token(Token = "0x6001FA8")]
	[Address(RVA = "0xD1D8A0", Offset = "0xD1CCA0", VA = "0x180D1D8A0", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public MountInformationInPaddockRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6001FAB")]
	[Address(RVA = "0xD1D920", Offset = "0xD1CD20", VA = "0x180D1D920", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FAC")]
	[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(MountInformationInPaddockRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FAD")]
	[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6001FAE")]
	[Address(RVA = "0xD1D9B0", Offset = "0xD1CDB0", VA = "0x180D1D9B0", Slot = "3")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6001FAF")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6001FB0")]
	[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6001FB1")]
	[Address(RVA = "0xD1D810", Offset = "0xD1CC10", VA = "0x180D1D810", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6001FB2")]
	[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(MountInformationInPaddockRequest other)
	{
	}

	[Token(Token = "0x6001FB3")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6001FB4")]
	[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
