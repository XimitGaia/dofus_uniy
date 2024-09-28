using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Com.Ankama.Dofus.Server.Game.Protocol.Common;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Character.Management;

[Token(Token = "0x200088E")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class CharacterCreationRequest : IMessage<CharacterCreationRequest>, IMessage, IEquatable<CharacterCreationRequest>, IDeepCloneable<CharacterCreationRequest>, IBufferMessage
{
	[Token(Token = "0x4001D95")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<CharacterCreationRequest> _parser;

	[Token(Token = "0x4001D96")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4001D97")]
	public const int ModelingInformationFieldNumber = 1;

	[Token(Token = "0x4001D98")]
	[FieldOffset(Offset = "0x18")]
	private CharacterRemodelingInformation modelingInformation_;

	[Token(Token = "0x1700134F")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<CharacterCreationRequest> Parser
	{
		[Token(Token = "0x6005AC2")]
		[Address(RVA = "0xB18290", Offset = "0xB17690", VA = "0x180B18290")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001350")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x6005AC3")]
		[Address(RVA = "0xB181E0", Offset = "0xB175E0", VA = "0x180B181E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001351")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x6005AC4")]
		[Address(RVA = "0xB183E0", Offset = "0xB177E0", VA = "0x180B183E0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001352")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterRemodelingInformation ModelingInformation
	{
		[Token(Token = "0x6005AC8")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005AC9")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x6005AC5")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCreationRequest()
	{
	}

	[Token(Token = "0x6005AC6")]
	[Address(RVA = "0xB18170", Offset = "0xB17570", VA = "0x180B18170")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public CharacterCreationRequest(CharacterCreationRequest other)
	{
	}

	[Token(Token = "0x6005AC7")]
	[Address(RVA = "0xB17DF0", Offset = "0xB171F0", VA = "0x180B17DF0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public CharacterCreationRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6005ACA")]
	[Address(RVA = "0xB17E90", Offset = "0xB17290", VA = "0x180B17E90", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005ACB")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(CharacterCreationRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6005ACC")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6005ACD")]
	[Address(RVA = "0xB18010", Offset = "0xB17410", VA = "0x180B18010", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6005ACE")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6005ACF")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6005AD0")]
	[Address(RVA = "0xB17D60", Offset = "0xB17160", VA = "0x180B17D60", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6005AD1")]
	[Address(RVA = "0xB17F40", Offset = "0xB17340", VA = "0x180B17F40", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CharacterCreationRequest other)
	{
	}

	[Token(Token = "0x6005AD2")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x6005AD3")]
	[Address(RVA = "0xB182E0", Offset = "0xB176E0", VA = "0x180B182E0", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
