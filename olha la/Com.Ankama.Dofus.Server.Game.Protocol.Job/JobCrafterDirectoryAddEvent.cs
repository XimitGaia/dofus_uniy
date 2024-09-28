using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Job;

[Token(Token = "0x2000363")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class JobCrafterDirectoryAddEvent : IMessage<JobCrafterDirectoryAddEvent>, IMessage, IEquatable<JobCrafterDirectoryAddEvent>, IDeepCloneable<JobCrafterDirectoryAddEvent>, IBufferMessage
{
	[Token(Token = "0x4000BA0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<JobCrafterDirectoryAddEvent> _parser;

	[Token(Token = "0x4000BA1")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000BA2")]
	public const int EntryFieldNumber = 1;

	[Token(Token = "0x4000BA3")]
	[FieldOffset(Offset = "0x18")]
	private JobCrafterDirectoryEntry entry_;

	[Token(Token = "0x1700077E")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageParser<JobCrafterDirectoryAddEvent> Parser
	{
		[Token(Token = "0x600230A")]
		[Address(RVA = "0x96B1E0", Offset = "0x96A5E0", VA = "0x18096B1E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077F")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x600230B")]
		[Address(RVA = "0x96B130", Offset = "0x96A530", VA = "0x18096B130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000780")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x600230C")]
		[Address(RVA = "0x96B330", Offset = "0x96A730", VA = "0x18096B330", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000781")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryEntry Entry
	{
		[Token(Token = "0x6002310")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002311")]
		[Address(RVA = "0x7F3FF0", Offset = "0x7F33F0", VA = "0x1807F3FF0")]
		set
		{
		}
	}

	[Token(Token = "0x600230D")]
	[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public JobCrafterDirectoryAddEvent()
	{
	}

	[Token(Token = "0x600230E")]
	[Address(RVA = "0x96AFF0", Offset = "0x96A3F0", VA = "0x18096AFF0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryAddEvent(JobCrafterDirectoryAddEvent other)
	{
	}

	[Token(Token = "0x600230F")]
	[Address(RVA = "0x96AAB0", Offset = "0x969EB0", VA = "0x18096AAB0", Slot = "10")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public JobCrafterDirectoryAddEvent Clone()
	{
		return null;
	}

	[Token(Token = "0x6002312")]
	[Address(RVA = "0x96AC10", Offset = "0x96A010", VA = "0x18096AC10", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002313")]
	[Address(RVA = "0x931120", Offset = "0x930520", VA = "0x180931120", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(JobCrafterDirectoryAddEvent other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002314")]
	[Address(RVA = "0x931240", Offset = "0x930640", VA = "0x180931240", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002315")]
	[Address(RVA = "0x96AE90", Offset = "0x96A290", VA = "0x18096AE90", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6002316")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x6002317")]
	[Address(RVA = "0x9319A0", Offset = "0x930DA0", VA = "0x1809319A0", Slot = "12")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x6002318")]
	[Address(RVA = "0x96AA20", Offset = "0x969E20", VA = "0x18096AA20", Slot = "7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x6002319")]
	[Address(RVA = "0x96ACC0", Offset = "0x96A0C0", VA = "0x18096ACC0", Slot = "4")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(JobCrafterDirectoryAddEvent other)
	{
	}

	[Token(Token = "0x600231A")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x600231B")]
	[Address(RVA = "0x96B230", Offset = "0x96A630", VA = "0x18096B230", Slot = "11")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
