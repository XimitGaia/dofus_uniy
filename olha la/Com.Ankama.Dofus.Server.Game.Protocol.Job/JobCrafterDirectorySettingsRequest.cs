using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x2000349")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobCrafterDirectorySettingsRequest : IMessage<JobCrafterDirectorySettingsRequest>, IMessage, IEquatable<JobCrafterDirectorySettingsRequest>, IDeepCloneable<JobCrafterDirectorySettingsRequest>, IBufferMessage
{
	[Token(Token = "0x4000B52")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobCrafterDirectorySettingsRequest> _parser;

	[Token(Token = "0x4000B53")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000B54")]
	public const int SettingsFieldNumber = 1;

	[Token(Token = "0x4000B55")]
	[FieldOffset(Offset = "0x18")]
	private JobCrafterDirectorySettings settings_;

	[Token(Token = "0x17000748")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<JobCrafterDirectorySettingsRequest> Parser
	{
		[Token(Token = "0x60021FC")]
		[Address(RVA = "0x9700F0", Offset = "0x96F4F0", VA = "0x1809700F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000749")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60021FD")]
		[Address(RVA = "0x970040", Offset = "0x96F440", VA = "0x180970040")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700074A")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60021FE")]
		[Address(RVA = "0x970240", Offset = "0x96F640", VA = "0x180970240", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700074B")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectorySettings Settings
	{
		[Token(Token = "0x6002202")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002203")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x60021FF")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectorySettingsRequest()
	{
	}

	[Token(Token = "0x6002200")]
	[Address(RVA = "0x96FFD0", Offset = "0x96F3D0", VA = "0x18096FFD0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectorySettingsRequest(JobCrafterDirectorySettingsRequest other)
	{
	}

	[Token(Token = "0x6002201")]
	[Address(RVA = "0x96FC50", Offset = "0x96F050", VA = "0x18096FC50", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectorySettingsRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x6002204")]
	[Address(RVA = "0x96FCF0", Offset = "0x96F0F0", VA = "0x18096FCF0", Slot = "0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002205")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public bool Equals(JobCrafterDirectorySettingsRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002206")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002207")]
	[Address(RVA = "0x96FE70", Offset = "0x96F270", VA = "0x18096FE70", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002208")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002209")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x600220A")]
	[Address(RVA = "0x96FBC0", Offset = "0x96EFC0", VA = "0x18096FBC0", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x600220B")]
	[Address(RVA = "0x96FDA0", Offset = "0x96F1A0", VA = "0x18096FDA0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JobCrafterDirectorySettingsRequest other)
	{
	}

	[Token(Token = "0x600220C")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600220D")]
	[Address(RVA = "0x970140", Offset = "0x96F540", VA = "0x180970140", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
