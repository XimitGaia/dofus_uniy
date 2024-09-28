using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Il2CppDummyDll;

namespace Com.Ankama.Dofus.Server.Game.Protocol.Preset;

[Token(Token = "0x2000224")]
[DebuggerDisplay("{ToString(),nq}")]
public sealed class PresetEquipmentUpdateRequest : IMessage<PresetEquipmentUpdateRequest>, IMessage, IEquatable<PresetEquipmentUpdateRequest>, IDeepCloneable<PresetEquipmentUpdateRequest>, IBufferMessage
{
	[Token(Token = "0x2000225")]
	public enum ActionOneofCase
	{
		[Token(Token = "0x4000751")]
		None = 0,
		[Token(Token = "0x4000752")]
		SetItem = 2,
		[Token(Token = "0x4000753")]
		RemoveItem = 3,
		[Token(Token = "0x4000754")]
		SetRide = 4,
		[Token(Token = "0x4000755")]
		RemoveRide = 5
	}

	[Token(Token = "0x2000226")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public static class Types
	{
		[Token(Token = "0x2000227")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class SetItem : IMessage<SetItem>, IMessage, IEquatable<SetItem>, IDeepCloneable<SetItem>, IBufferMessage
		{
			[Token(Token = "0x4000756")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<SetItem> _parser;

			[Token(Token = "0x4000757")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x4000758")]
			public const int PositionFieldNumber = 1;

			[Token(Token = "0x4000759")]
			[FieldOffset(Offset = "0x18")]
			private int position_;

			[Token(Token = "0x400075A")]
			public const int ItemUidFieldNumber = 2;

			[Token(Token = "0x400075B")]
			[FieldOffset(Offset = "0x1C")]
			private int itemUid_;

			[Token(Token = "0x170004AF")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<SetItem> Parser
			{
				[Token(Token = "0x60015DE")]
				[Address(RVA = "0xCEC400", Offset = "0xCEB800", VA = "0x180CEC400")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004B0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60015DF")]
				[Address(RVA = "0xCEC380", Offset = "0xCEB780", VA = "0x180CEC380")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004B1")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60015E0")]
				[Address(RVA = "0xCEC450", Offset = "0xCEB850", VA = "0x180CEC450", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004B2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Position
			{
				[Token(Token = "0x60015E4")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60015E5")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x170004B3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int ItemUid
			{
				[Token(Token = "0x60015E6")]
				[Address(RVA = "0x87EAE0", Offset = "0x87DEE0", VA = "0x18087EAE0")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60015E7")]
				[Address(RVA = "0x87EB10", Offset = "0x87DF10", VA = "0x18087EB10")]
				set
				{
				}
			}

			[Token(Token = "0x60015E1")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SetItem()
			{
			}

			[Token(Token = "0x60015E2")]
			[Address(RVA = "0x93ACF0", Offset = "0x93A0F0", VA = "0x18093ACF0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SetItem(SetItem other)
			{
			}

			[Token(Token = "0x60015E3")]
			[Address(RVA = "0xCEC100", Offset = "0xCEB500", VA = "0x180CEC100", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SetItem Clone()
			{
				return null;
			}

			[Token(Token = "0x60015E8")]
			[Address(RVA = "0xCEC190", Offset = "0xCEB590", VA = "0x180CEC190", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60015E9")]
			[Address(RVA = "0x93AA70", Offset = "0x939E70", VA = "0x18093AA70", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(SetItem other)
			{
				return default(bool);
			}

			[Token(Token = "0x60015EA")]
			[Address(RVA = "0x9691C0", Offset = "0x9685C0", VA = "0x1809691C0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x60015EB")]
			[Address(RVA = "0xCEC220", Offset = "0xCEB620", VA = "0x180CEC220", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x60015EC")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x60015ED")]
			[Address(RVA = "0x969480", Offset = "0x968880", VA = "0x180969480", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x60015EE")]
			[Address(RVA = "0xCEC040", Offset = "0xCEB440", VA = "0x180CEC040", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x60015EF")]
			[Address(RVA = "0x93AB30", Offset = "0x939F30", VA = "0x18093AB30", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(SetItem other)
			{
			}

			[Token(Token = "0x60015F0")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x60015F1")]
			[Address(RVA = "0x93AE20", Offset = "0x93A220", VA = "0x18093AE20", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x2000229")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class RemoveItem : IMessage<RemoveItem>, IMessage, IEquatable<RemoveItem>, IDeepCloneable<RemoveItem>, IBufferMessage
		{
			[Token(Token = "0x400075D")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<RemoveItem> _parser;

			[Token(Token = "0x400075E")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x400075F")]
			public const int PositionFieldNumber = 1;

			[Token(Token = "0x4000760")]
			[FieldOffset(Offset = "0x18")]
			private int position_;

			[Token(Token = "0x170004B4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<RemoveItem> Parser
			{
				[Token(Token = "0x60015F6")]
				[Address(RVA = "0xCEBB60", Offset = "0xCEAF60", VA = "0x180CEBB60")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004B5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x60015F7")]
				[Address(RVA = "0xCEBAE0", Offset = "0xCEAEE0", VA = "0x180CEBAE0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004B6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x60015F8")]
				[Address(RVA = "0xCEBBB0", Offset = "0xCEAFB0", VA = "0x180CEBBB0", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004B7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int Position
			{
				[Token(Token = "0x60015FC")]
				[Address(RVA = "0x894410", Offset = "0x893810", VA = "0x180894410")]
				get
				{
					return default(int);
				}
				[Token(Token = "0x60015FD")]
				[Address(RVA = "0x894490", Offset = "0x893890", VA = "0x180894490")]
				set
				{
				}
			}

			[Token(Token = "0x60015F9")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RemoveItem()
			{
			}

			[Token(Token = "0x60015FA")]
			[Address(RVA = "0x929150", Offset = "0x928550", VA = "0x180929150")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RemoveItem(RemoveItem other)
			{
			}

			[Token(Token = "0x60015FB")]
			[Address(RVA = "0xCEB870", Offset = "0xCEAC70", VA = "0x180CEB870", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RemoveItem Clone()
			{
				return null;
			}

			[Token(Token = "0x60015FE")]
			[Address(RVA = "0xCEB8F0", Offset = "0xCEACF0", VA = "0x180CEB8F0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x60015FF")]
			[Address(RVA = "0x928E70", Offset = "0x928270", VA = "0x180928E70", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(RemoveItem other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001600")]
			[Address(RVA = "0x928F30", Offset = "0x928330", VA = "0x180928F30", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6001601")]
			[Address(RVA = "0xCEB980", Offset = "0xCEAD80", VA = "0x180CEB980", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6001602")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6001603")]
			[Address(RVA = "0x929340", Offset = "0x928740", VA = "0x180929340", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6001604")]
			[Address(RVA = "0xCEB7E0", Offset = "0xCEABE0", VA = "0x180CEB7E0", Slot = "7")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6001605")]
			[Address(RVA = "0x928FA0", Offset = "0x9283A0", VA = "0x180928FA0", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(RemoveItem other)
			{
			}

			[Token(Token = "0x6001606")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x6001607")]
			[Address(RVA = "0x9292A0", Offset = "0x9286A0", VA = "0x1809292A0", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x200022B")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class SetRide : IMessage<SetRide>, IMessage, IEquatable<SetRide>, IDeepCloneable<SetRide>, IBufferMessage
		{
			[Token(Token = "0x4000762")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<SetRide> _parser;

			[Token(Token = "0x4000763")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x170004B8")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public static MessageParser<SetRide> Parser
			{
				[Token(Token = "0x600160C")]
				[Address(RVA = "0xCEC7E0", Offset = "0xCEBBE0", VA = "0x180CEC7E0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004B9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x600160D")]
				[Address(RVA = "0xCEC760", Offset = "0xCEBB60", VA = "0x180CEC760")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004BA")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x600160E")]
				[Address(RVA = "0xCEC830", Offset = "0xCEBC30", VA = "0x180CEC830", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x600160F")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SetRide()
			{
			}

			[Token(Token = "0x6001610")]
			[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public SetRide(SetRide other)
			{
			}

			[Token(Token = "0x6001611")]
			[Address(RVA = "0xCEC500", Offset = "0xCEB900", VA = "0x180CEC500", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public SetRide Clone()
			{
				return null;
			}

			[Token(Token = "0x6001612")]
			[Address(RVA = "0xCEC580", Offset = "0xCEB980", VA = "0x180CEC580", Slot = "0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001613")]
			[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public bool Equals(SetRide other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001614")]
			[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6001615")]
			[Address(RVA = "0xCEC600", Offset = "0xCEBA00", VA = "0x180CEC600", Slot = "3")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x6001616")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x6001617")]
			[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x6001618")]
			[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x6001619")]
			[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void MergeFrom(SetRide other)
			{
			}

			[Token(Token = "0x600161A")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600161B")]
			[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}

		[Token(Token = "0x200022D")]
		[DebuggerDisplay("{ToString(),nq}")]
		public sealed class RemoveRide : IMessage<RemoveRide>, IMessage, IEquatable<RemoveRide>, IDeepCloneable<RemoveRide>, IBufferMessage
		{
			[Token(Token = "0x4000765")]
			[FieldOffset(Offset = "0x0")]
			private static readonly MessageParser<RemoveRide> _parser;

			[Token(Token = "0x4000766")]
			[FieldOffset(Offset = "0x10")]
			private UnknownFieldSet _unknownFields;

			[Token(Token = "0x170004BB")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageParser<RemoveRide> Parser
			{
				[Token(Token = "0x6001620")]
				[Address(RVA = "0xCEBF40", Offset = "0xCEB340", VA = "0x180CEBF40")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004BC")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public static MessageDescriptor Descriptor
			{
				[Token(Token = "0x6001621")]
				[Address(RVA = "0xCEBEC0", Offset = "0xCEB2C0", VA = "0x180CEBEC0")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170004BD")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
			{
				[Token(Token = "0x6001622")]
				[Address(RVA = "0xCEBF90", Offset = "0xCEB390", VA = "0x180CEBF90", Slot = "8")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6001623")]
			[Address(RVA = "0x7B00C0", Offset = "0x7AF4C0", VA = "0x1807B00C0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RemoveRide()
			{
			}

			[Token(Token = "0x6001624")]
			[Address(RVA = "0x923CD0", Offset = "0x9230D0", VA = "0x180923CD0")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public RemoveRide(RemoveRide other)
			{
			}

			[Token(Token = "0x6001625")]
			[Address(RVA = "0xCEBC60", Offset = "0xCEB060", VA = "0x180CEBC60", Slot = "10")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public RemoveRide Clone()
			{
				return null;
			}

			[Token(Token = "0x6001626")]
			[Address(RVA = "0xCEBCE0", Offset = "0xCEB0E0", VA = "0x180CEBCE0", Slot = "0")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override bool Equals(object other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001627")]
			[Address(RVA = "0x923AC0", Offset = "0x922EC0", VA = "0x180923AC0", Slot = "9")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public bool Equals(RemoveRide other)
			{
				return default(bool);
			}

			[Token(Token = "0x6001628")]
			[Address(RVA = "0x923AE0", Offset = "0x922EE0", VA = "0x180923AE0", Slot = "2")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override int GetHashCode()
			{
				return default(int);
			}

			[Token(Token = "0x6001629")]
			[Address(RVA = "0xCEBD60", Offset = "0xCEB160", VA = "0x180CEBD60", Slot = "3")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public override string ToString()
			{
				return null;
			}

			[Token(Token = "0x600162A")]
			[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
			[DebuggerNonUserCode]
			[GeneratedCode("protoc", null)]
			public void WriteTo(CodedOutputStream output)
			{
			}

			[Token(Token = "0x600162B")]
			[Address(RVA = "0x923EA0", Offset = "0x9232A0", VA = "0x180923EA0", Slot = "12")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
			{
			}

			[Token(Token = "0x600162C")]
			[Address(RVA = "0x9239A0", Offset = "0x922DA0", VA = "0x1809239A0", Slot = "7")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public int CalculateSize()
			{
				return default(int);
			}

			[Token(Token = "0x600162D")]
			[Address(RVA = "0x923B20", Offset = "0x922F20", VA = "0x180923B20", Slot = "4")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(RemoveRide other)
			{
			}

			[Token(Token = "0x600162E")]
			[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			public void MergeFrom(CodedInputStream input)
			{
			}

			[Token(Token = "0x600162F")]
			[Address(RVA = "0x923E20", Offset = "0x923220", VA = "0x180923E20", Slot = "11")]
			[GeneratedCode("protoc", null)]
			[DebuggerNonUserCode]
			private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
			{
			}
		}
	}

	[Token(Token = "0x4000746")]
	[FieldOffset(Offset = "0x0")]
	private static readonly MessageParser<PresetEquipmentUpdateRequest> _parser;

	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0x10")]
	private UnknownFieldSet _unknownFields;

	[Token(Token = "0x4000748")]
	public const int CharacterPresetUuidFieldNumber = 1;

	[Token(Token = "0x4000749")]
	[FieldOffset(Offset = "0x18")]
	private string characterPresetUuid_;

	[Token(Token = "0x400074A")]
	public const int SetItemFieldNumber = 2;

	[Token(Token = "0x400074B")]
	public const int RemoveItemFieldNumber = 3;

	[Token(Token = "0x400074C")]
	public const int SetRideFieldNumber = 4;

	[Token(Token = "0x400074D")]
	public const int RemoveRideFieldNumber = 5;

	[Token(Token = "0x400074E")]
	[FieldOffset(Offset = "0x20")]
	private object action_;

	[Token(Token = "0x400074F")]
	[FieldOffset(Offset = "0x28")]
	private ActionOneofCase actionCase_;

	[Token(Token = "0x170004A6")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageParser<PresetEquipmentUpdateRequest> Parser
	{
		[Token(Token = "0x60015C1")]
		[Address(RVA = "0xCE3EA0", Offset = "0xCE32A0", VA = "0x180CE3EA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A7")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public static MessageDescriptor Descriptor
	{
		[Token(Token = "0x60015C2")]
		[Address(RVA = "0xCE3DF0", Offset = "0xCE31F0", VA = "0x180CE3DF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A8")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	private MessageDescriptor pb_003A_003AGoogle_002EProtobuf_002EIMessage_002EDescriptor
	{
		[Token(Token = "0x60015C3")]
		[Address(RVA = "0xCE4610", Offset = "0xCE3A10", VA = "0x180CE4610", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170004A9")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public string CharacterPresetUuid
	{
		[Token(Token = "0x60015C7")]
		[Address(RVA = "0x7D2760", Offset = "0x7D1B60", VA = "0x1807D2760")]
		get
		{
			return null;
		}
		[Token(Token = "0x60015C8")]
		[Address(RVA = "0xCE4650", Offset = "0xCE3A50", VA = "0x180CE4650")]
		set
		{
		}
	}

	[Token(Token = "0x170004AA")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.SetItem SetItem
	{
		[Token(Token = "0x60015C9")]
		[Address(RVA = "0xCE3FB0", Offset = "0xCE33B0", VA = "0x180CE3FB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60015CA")]
		[Address(RVA = "0x926590", Offset = "0x925990", VA = "0x180926590")]
		set
		{
		}
	}

	[Token(Token = "0x170004AB")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public Types.RemoveItem RemoveItem
	{
		[Token(Token = "0x60015CB")]
		[Address(RVA = "0xCE3EF0", Offset = "0xCE32F0", VA = "0x180CE3EF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60015CC")]
		[Address(RVA = "0x926550", Offset = "0x925950", VA = "0x180926550")]
		set
		{
		}
	}

	[Token(Token = "0x170004AC")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.SetRide SetRide
	{
		[Token(Token = "0x60015CD")]
		[Address(RVA = "0xCE4010", Offset = "0xCE3410", VA = "0x180CE4010")]
		get
		{
			return null;
		}
		[Token(Token = "0x60015CE")]
		[Address(RVA = "0x926610", Offset = "0x925A10", VA = "0x180926610")]
		set
		{
		}
	}

	[Token(Token = "0x170004AD")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public Types.RemoveRide RemoveRide
	{
		[Token(Token = "0x60015CF")]
		[Address(RVA = "0xCE3F50", Offset = "0xCE3350", VA = "0x180CE3F50")]
		get
		{
			return null;
		}
		[Token(Token = "0x60015D0")]
		[Address(RVA = "0x9264D0", Offset = "0x9258D0", VA = "0x1809264D0")]
		set
		{
		}
	}

	[Token(Token = "0x170004AE")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public ActionOneofCase ActionCase
	{
		[Token(Token = "0x60015D1")]
		[Address(RVA = "0x87D130", Offset = "0x87C530", VA = "0x18087D130")]
		get
		{
			return default(ActionOneofCase);
		}
	}

	[Token(Token = "0x60015C4")]
	[Address(RVA = "0xCE3DA0", Offset = "0xCE31A0", VA = "0x180CE3DA0")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public PresetEquipmentUpdateRequest()
	{
	}

	[Token(Token = "0x60015C5")]
	[Address(RVA = "0xCE3AC0", Offset = "0xCE2EC0", VA = "0x180CE3AC0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetEquipmentUpdateRequest(PresetEquipmentUpdateRequest other)
	{
	}

	[Token(Token = "0x60015C6")]
	[Address(RVA = "0xCE3160", Offset = "0xCE2560", VA = "0x180CE3160", Slot = "10")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public PresetEquipmentUpdateRequest Clone()
	{
		return null;
	}

	[Token(Token = "0x60015D2")]
	[Address(RVA = "0x9247A0", Offset = "0x923BA0", VA = "0x1809247A0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void ClearAction()
	{
	}

	[Token(Token = "0x60015D3")]
	[Address(RVA = "0xCE3300", Offset = "0xCE2700", VA = "0x180CE3300", Slot = "0")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Token(Token = "0x60015D4")]
	[Address(RVA = "0xCE31C0", Offset = "0xCE25C0", VA = "0x180CE31C0", Slot = "9")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public bool Equals(PresetEquipmentUpdateRequest other)
	{
		return default(bool);
	}

	[Token(Token = "0x60015D5")]
	[Address(RVA = "0xCE3470", Offset = "0xCE2870", VA = "0x180CE3470", Slot = "2")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60015D6")]
	[Address(RVA = "0xCE3960", Offset = "0xCE2D60", VA = "0x180CE3960", Slot = "3")]
	[DebuggerNonUserCode]
	[GeneratedCode("protoc", null)]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60015D7")]
	[Address(RVA = "0x916500", Offset = "0x915900", VA = "0x180916500", Slot = "6")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void WriteTo(CodedOutputStream output)
	{
	}

	[Token(Token = "0x60015D8")]
	[Address(RVA = "0xCE43F0", Offset = "0xCE37F0", VA = "0x180CE43F0", Slot = "12")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalWriteTo(ref WriteContext output)
	{
	}

	[Token(Token = "0x60015D9")]
	[Address(RVA = "0xCE2F00", Offset = "0xCE2300", VA = "0x180CE2F00", Slot = "7")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public int CalculateSize()
	{
		return default(int);
	}

	[Token(Token = "0x60015DA")]
	[Address(RVA = "0xCE36B0", Offset = "0xCE2AB0", VA = "0x180CE36B0", Slot = "4")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(PresetEquipmentUpdateRequest other)
	{
	}

	[Token(Token = "0x60015DB")]
	[Address(RVA = "0x9163F0", Offset = "0x9157F0", VA = "0x1809163F0", Slot = "5")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	public void MergeFrom(CodedInputStream input)
	{
	}

	[Token(Token = "0x60015DC")]
	[Address(RVA = "0xCE4070", Offset = "0xCE3470", VA = "0x180CE4070", Slot = "11")]
	[GeneratedCode("protoc", null)]
	[DebuggerNonUserCode]
	private void pb_003A_003AGoogle_002EProtobuf_002EIBufferMessage_002EInternalMergeFrom(ref ParseContext input)
	{
	}
}
